using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using BiblioSystem.Entities;

namespace BiblioSystem.Database
{
    public class DatabaseConnector
    {
        public enum Mode
        {
            Authors,
            Admins
        }

        private static List<Publication> RetreivePublications(SQLiteCommand command)
        {
            DataTable table = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(table);

            List<Publication> publications = new List<Publication>();

            foreach (DataRow row in table.Rows)
            {
                Publication publication = new Publication()
                {
                    id = Convert.ToInt32(row["id"]),
                    Name = row["Name"].ToString()
                };

                publications.Add(publication);
            }

            return publications;
        }

        private static void ExecuteCommand(SQLiteConnection connection, SQLiteCommand command)
        {
            connection.Open();

            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Publication> LoadPublications()
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select * from Publications";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                return RetreivePublications(command);
            }
        }

        public static List<Publication> LoadPublications(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select * from Publications where name=@name";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("name", name);
                return RetreivePublications(command);
            }
        }

        public static List<Publication> LoadPublications(Author author)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = 
                    "SELECT Publications.id, Publications.Name " +
                    "FROM Relations INNER JOIN Publications " +
                    "ON Relations.publication_id = Publications.id " +
                    "WHERE Relations.author_id = @id";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("id", author.id);

                return RetreivePublications(command);
            }
        }

        public static int CountCitations(Publication publication)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select id from Citations where citation_publication_id=@id";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("id", publication.id);

                DataTable table = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(table);

                return table.Rows.Count;
            }
        }

        public static void DeletePublication(Publication publication)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "delete from Publications where id=@id";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("id", publication.id);

                ExecuteCommand(connection, command);
                DeleteRelation(publication);
                DeleteCitation(publication);
            }
        }

        public static void DeleteRelation(Publication publication)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "delete from Relations where publication_id=@id";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("id", publication.id);

                ExecuteCommand(connection, command);
            }
        }

        public static void DeleteCitation(Publication publication)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "delete from Citations where publication_id=@id";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("id", publication.id);

                ExecuteCommand(connection, command);
            }
        }

        public static void DeleteCitation(Citation citation)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                int id = ContainsPublication(new Publication() { Name = citation.PublicationName }),
                    pid = ContainsPublication(new Publication() { Name = citation.CitationPublicationName });

                string query = "delete from Citations where publication_id=@id and citation_publication_id=@pid";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("pid", pid);

                ExecuteCommand(connection, command);
            }
        }

        public static void DeleteRelation(Author author, Publication publication)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "delete from Relations where publication_id=@pid and author_id=@aid";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("pid", publication.id);
                command.Parameters.AddWithValue("aid", author.id);

                ExecuteCommand(connection, command);
            }
        }

        public static int ContainsAuthor(Author author)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select * from Authors where Name=@name";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("name", author.Name);

                DataTable table = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count != 0)
                    return Convert.ToInt32(table.Rows[0]["id"]);
                else
                    return 0;
            }
        }

        public static int ContainsPublication(Publication publication)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select * from Publications where Name=@name";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("name", publication.Name);

                DataTable table = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count != 0)
                    return Convert.ToInt32(table.Rows[0]["id"]);
                else
                    return 0;
            }
        }

        public static int InsertPublication(Publication publication)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "insert into Publications(Name) values(@name)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("name", publication.Name);

                ExecuteCommand(connection, command);

                query = "select id from Publications where Name=@name";
                command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("name", publication.Name);

                DataTable table = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(table);

                int count = table.Rows.Count;

                if (count == 0)
                    return 0;
                else
                    return Convert.ToInt32(table.Rows[count - 1]["id"]);
            }
        }

        public static void InsertRelations(Publication publication, List<Author> authors)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "insert into Relations(publication_id, author_id) values(@pid, @aid)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("pid", publication.id);

                foreach (var author in authors)
                {
                    command.Parameters.AddWithValue("aid", author.id);
                    ExecuteCommand(connection, command);
                } 
            }
        }

        public static void InsertCitations(Publication publication, List<Publication> citations)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "insert into Citations(publication_id, citation_publication_id) values(@pid, @cid)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("pid", publication.id);

                foreach (var citation in citations)
                {
                    command.Parameters.AddWithValue("cid", citation.id);
                    ExecuteCommand(connection, command);
                }
            }
        }

        public static bool CheckLogin(Author author, Mode mode)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select * from " + mode.ToString() + " where Username=@name";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("name", author.Username);

                DataTable table = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                    return false;
                else
                {
                    if (author.Password != table.Rows[0]["password"].ToString())
                        return false;
                    else
                    {
                        author.id = Convert.ToInt32(table.Rows[0]["id"]);
                        return true;
                    }
                }
            }
        }

        public static int ContainsUsername(Author author)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "select * from Authors where Username=@name";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("name", author.Username);

                DataTable table = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count != 0)
                    return Convert.ToInt32(table.Rows[0]["id"]);
                else
                    return 0;
            }
        }

        public static void AddAuthor(Author author)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "insert into Authors(Name, Username, Password) values(@name, @uname, @passw)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("name", author.Name);
                command.Parameters.AddWithValue("uname", author.Username);
                command.Parameters.AddWithValue("passw", author.Password);

                ExecuteCommand(connection, command);
            }
        }

        public static List<Citation> LoadCitations(List<Publication> publications)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT Result.Name, Publications.Name as PName " +
                    "FROM (SELECT Publications.Name as Name, Citations.citation_publication_id as pid " +
                    "FROM Citations INNER JOIN Publications " +
                    "ON Citations.publication_id = Publications.id " +
                    "WHERE Citations.publication_id = @id) as Result " +
                    "INNER JOIN Publications ON Result.pid = Publications.id";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                List<Citation> citations = new List<Citation>();

                foreach (var publication in publications)
                {
                    command.Parameters.AddWithValue("id", publication.id);

                    DataTable table = new DataTable();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    adapter.Fill(table);

                    if (table.Rows.Count != 0)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            Citation citation = new Citation()
                            {
                                PublicationName = row["Name"].ToString(),
                                CitationPublicationName = row["PName"].ToString()
                            };

                            citations.Add(citation);
                        }
                    }
                }

                return citations;
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

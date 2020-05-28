using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BiblioSystem.Entities;
using BiblioSystem.Database;

namespace BiblioSystem.UI
{
    public partial class AddForm : Form
    {
        private TableViewForm hidden;

        private List<Author> authors = new List<Author>();

        private List<Publication> citations = new List<Publication>();

        public AddForm(Form hidden)
        {
            InitializeComponent();
            this.hidden = (TableViewForm)hidden;
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                Name = authorTextBox.Text
            };

            author.id = DatabaseConnector.ContainsAuthor(author);

            if (author.id != 0)
            {
                authors.Add(author);
                authorsBuffer.Add(author);

                authorGridView.DataSource = 
                    authorGridView.DataSource == authors ? authorsBuffer : authors;
                authorGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Такого автора нет в базе, попробуйте ещё раз.");
            }

            authorTextBox.Text = "";
        }

        private void addCitationButton_Click(object sender, EventArgs e)
        {
            Publication publication = new Publication()
            {
                Name = citationTextBox.Text
            };

            publication.id = DatabaseConnector.ContainsPublication(publication);

            if (publication.id != 0)
            {
                citations.Add(publication);
                citationsBuffer.Add(publication);

                citationGridView.DataSource = 
                    citationGridView.DataSource == citations ? citationsBuffer : citations;
                citationGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Такой публикации нет в базе, попробуйте ещё раз.");
            }

            citationTextBox.Text = "";
        }

        private void authorGridView_Paint(object sender, PaintEventArgs e)
        {
            if (authors.Count != 0)
            {
                authorGridView.Columns[0].Visible = false;
                authorGridView.Columns[1].Width = 400;
            }
        }

        private void citationGridView_Paint(object sender, PaintEventArgs e)
        {
            if (citations.Count != 0)
            {
                citationGridView.Columns[0].Visible = false;
                citationGridView.Columns[1].Width = 400;
            }
        }

        private void addPublicationButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Пожаулуйста, введите имя публикации.");
            }
            else
            {
                Publication publication = new Publication()
                {
                    Name = nameTextBox.Text
                };

                publication.id = DatabaseConnector.InsertPublication(publication);
                DatabaseConnector.InsertRelations(publication, authors);
                DatabaseConnector.InsertCitations(publication, citations);

                Close();

                foreach (Control control in hidden.Controls)
                    control.Visible = true;
            }
        }

        private List<Author> authorsBuffer = new List<Author>();
        private List<Publication> citationsBuffer = new List<Publication>();
    }
}

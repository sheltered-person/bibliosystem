using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioSystem.Entities;
using BiblioSystem.Database;

namespace BiblioSystem
{
    public partial class TableViewForm : Form
    {
        private UI.AddForm addForm;

        private List<Publication> publications;

        private Author user;

        private string publicationName = null;

        public TableViewForm(Author user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addForm = new UI.AddForm(this)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            foreach (Control control in Controls)
                control.Visible = false;

            Controls.Add(addForm);
            addForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = dataGridView.CurrentCell.RowIndex;

            if (user.isAdmin)
                DatabaseConnector.DeletePublication(publications[id]);
            else
                DatabaseConnector.DeleteRelation(user, publications[id]);

            Refresh();
        }

        private void TableViewForm_Paint(object sender, PaintEventArgs e)
        {
            if (!user.isAdmin)
            {
                addButton.Visible = false;
                searchButton.Visible = false;
                searchTextBox.Visible = false;
            }

            if (user.isAdmin)
            {
                if (publicationName == null)
                    publications = DatabaseConnector.LoadPublications();
                else
                    publications = DatabaseConnector.LoadPublications(publicationName);
            }
            else
                publications = DatabaseConnector.LoadPublications(user);

            dataGridView.DataSource = publications;
            dataGridView.Columns[1].Width = 400;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (publicationName != null)
                publicationName = null;
            else
            {
                if (searchTextBox.Text != "")
                    publicationName = searchTextBox.Text;
                else
                {
                    MessageBox.Show("Пожалуйста, введите название публикации для поиска");
                    return;
                }
            }

            Refresh();
        }
    }
}

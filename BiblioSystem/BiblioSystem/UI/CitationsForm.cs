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

namespace BiblioSystem.UI
{
    public partial class CitationsForm : Form
    {
        private Author user;
        private List<Publication> publications;
        private List<Citation> citations;
        private RelationForm relationForm;

        public CitationsForm(Author user)
        {
            InitializeComponent();
            this.user = user;

            publications = DatabaseConnector.LoadPublications(user);
            citations = DatabaseConnector.LoadCitations(publications);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = dataGridView.CurrentCell.RowIndex;

            DatabaseConnector.DeleteCitation(citations[id]);
            citations.Remove(citations[id]);

            Refresh();
        }

        private void CitationsForm_Paint(object sender, PaintEventArgs e)
        {
            citations = DatabaseConnector.LoadCitations(publications);

            dataGridView.DataSource = citations;
            dataGridView.Columns[0].Width = 200;
            dataGridView.Columns[1].Width = 200;
        }

        private void addCitationButton_Click(object sender, EventArgs e)
        {
            relationForm = new RelationForm(this, publications)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            foreach (Control control in Controls)
                control.Visible = false;

            Controls.Add(relationForm);
            relationForm.Show();
        }
    }
}

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
    public partial class RelationForm : Form
    {
        private CitationsForm hidden;
        private List<Publication> authorPublications;
        private List<Publication> publications;

        public RelationForm(CitationsForm hidden, List<Publication> publications)
        {
            InitializeComponent();

            this.hidden = hidden;
            this.authorPublications = publications;
            this.publications = DatabaseConnector.LoadPublications();

            ownGridView.DataSource = authorPublications;
            allGridView.DataSource = this.publications;

            ownGridView.Columns[0].Visible = false;
            allGridView.Columns[0].Visible = false;

            ownGridView.Columns[1].Width = 400;
            allGridView.Columns[1].Width = 400;
        }

        private void citationButton_Click(object sender, EventArgs e)
        {
            int id = ownGridView.CurrentCell.RowIndex;
            int pid = allGridView.CurrentCell.RowIndex;

            DatabaseConnector.InsertCitations(authorPublications[id], 
                new List<Publication>() { publications[pid] });

            Close();

            foreach (Control control in hidden.Controls)
                control.Visible = true;
        }
    }
}

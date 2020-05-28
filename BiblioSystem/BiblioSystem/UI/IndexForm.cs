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
    public partial class IndexForm : Form
    {
        private Author user;
        private List<Publication> publications;
        private int citationIndex = 1;

        public IndexForm(Author user)
        {
            InitializeComponent();
            this.user = user;
            publications = DatabaseConnector.LoadPublications(user);

            foreach (var publication in publications)
                publication.Citations = DatabaseConnector.CountCitations(publication);

            publications.Sort(Comparer<Publication>.Create((x, y) =>
            {
                return y.Citations.CompareTo(x.Citations);
            }));

            for (int i = 0; i + 1 <= publications[i].Citations; i++)
                citationIndex++;

            indexLabel.Text = citationIndex.ToString();
        }
    }
}

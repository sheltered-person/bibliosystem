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

namespace BiblioSystem
{
    public partial class MainMenuForm : Form
    {
        private LoginForm logForm;
        private TableViewForm tableForm;
        private UI.IndexForm indexForm;
        private UI.CitationsForm citationsForm;

        private Author user;

        public MainMenuForm()
        {
            InitializeComponent();

            ToolStripManager.Renderer = 
                new ToolStripProfessionalRenderer(new CustomProfessionalColors());

            menuStrip.Visible = false;

            user = new Author();
            user.isAdmin = false;

            logForm = new LoginForm(user, rightPanel, descriptionPanel)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            rightPanel.Controls.Add(logForm);
            logForm.Show();
        }

        class CustomProfessionalColors : ProfessionalColorTable
        {
            private Color color = Color.Honeydew;

            public override Color MenuItemSelectedGradientBegin => color;

            public override Color MenuItemSelectedGradientEnd => color;

            public override Color MenuItemBorder => color;

            public override Color ButtonCheckedGradientBegin => color;

            public override Color ButtonCheckedGradientEnd => color;
        }

        private void ModifyForm()
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
                item.ForeColor = Color.Black;

            foreach (Control control in descriptionPanel.Controls)
                control.Visible = false;
        }

        private void mainScreenMenuItem_Click(object sender, EventArgs e)
        {
            ModifyForm();

            mainScreenMenuItem.ForeColor = Color.SeaGreen;
            mainMenuPanel.Visible = true;
        }

        private void pListMenuItem_Click(object sender, EventArgs e)
        {
            ModifyForm();

            pListMenuItem.ForeColor = Color.SeaGreen;

            tableForm = new TableViewForm(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            descriptionPanel.Controls.Add(tableForm);
            tableForm.Show();
        }

        private void indexMenuItem_Click(object sender, EventArgs e)
        {
            ModifyForm();

            indexMenuItem.ForeColor = Color.SeaGreen;

            if (user.isAdmin)
                mainMenuPanel.Visible = true;
            else
            {
                indexForm = new UI.IndexForm(user)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                descriptionPanel.Controls.Add(indexForm);
                indexForm.Show();
            }
        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {
            ModifyForm();

            logOutMenuItem.ForeColor = Color.SeaGreen;
            mainMenuPanel.Visible = true;
            menuStrip.Visible = false;

            user = new Author();
            user.isAdmin = false;

            logForm = new LoginForm(user, rightPanel, descriptionPanel)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            rightPanel.Controls.Add(logForm);
            logForm.Show();
        }

        private void citationMenuItem_Click(object sender, EventArgs e)
        {
            ModifyForm();

            citationMenuItem.ForeColor = Color.SeaGreen;

            if (user.isAdmin)
                mainMenuPanel.Visible = true;
            else
            {
                citationsForm = new UI.CitationsForm(user)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                descriptionPanel.Controls.Add(citationsForm);
                citationsForm.Show();
            }
        }
    }
}

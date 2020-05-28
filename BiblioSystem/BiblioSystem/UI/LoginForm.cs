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
    public partial class LoginForm : Form
    {
        private Panel logPanel;
        private Panel signPanel;
        private SignUpForm signForm;

        private Author user;


        public LoginForm(Author user,
            Panel logPanel, Panel signPanel)
        {
            InitializeComponent();

            passwTextBox.PasswordChar = '*';
            passwTextBox.UseSystemPasswordChar = true;

            this.signPanel = signPanel;
            this.logPanel = logPanel;

            this.user = user;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            signForm = new SignUpForm(signPanel.Controls)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            signPanel.Controls.Add(signForm);
            signForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in logPanel.Controls)
                control.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwTextBox.Text == "")
            {
                MessageBox.Show("Имя пользователя или пароль отсутствуют.");
            }
            else
            {
                user.Username = usernameTextBox.Text;
                user.Password = passwTextBox.Text;

                if (adminRadioButton.Checked)
                {
                    if (DatabaseConnector.CheckLogin(user, DatabaseConnector.Mode.Admins))
                    {
                        user.isAdmin = true;
                        Close();

                        foreach (Control control in logPanel.Controls)
                            control.Visible = true;
                    }
                    else
                        MessageBox.Show("Неверный логин или пароль.");
                }
                else
                {
                    if (DatabaseConnector.CheckLogin(user, DatabaseConnector.Mode.Authors))
                    {
                        Close();

                        foreach (Control control in logPanel.Controls)
                            control.Visible = true;
                    }
                    else
                        MessageBox.Show("Неверный логин или пароль.");
                }
            }
        }
    }
}

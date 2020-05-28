using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioSystem.Database;
using BiblioSystem.Entities;

namespace BiblioSystem
{
    public partial class SignUpForm : Form
    {
        private Control.ControlCollection defaultControls;


        public SignUpForm(Control.ControlCollection defaultControls)
        {
            this.defaultControls = defaultControls;

            foreach (Control control in this.defaultControls)
                control.Visible = false;

            InitializeComponent();
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" 
                || passwTextBox.Text == "" || passwRepeatTextBox.Text == "")
            {
                MessageBox.Show("Некоторые поля пустуют, введите все данные.");
            }
            else
            {
                if (passwTextBox.Text != passwRepeatTextBox.Text)
                {
                    MessageBox.Show("Введённые пароли не совпадают, попробуйте ещё раз.");
                }
                else
                {
                    Author author = new Author()
                    {
                        Name = nameTextBox.Text,
                        Username = usernameTextBox.Text,
                        Password = passwTextBox.Text
                    };

                    if (DatabaseConnector.ContainsUsername(author) != 0)
                    {
                        MessageBox.Show("Пользователь с таким именем уже существует.");
                    }
                    else
                    {
                        DatabaseConnector.AddAuthor(author);

                        Close();
                        foreach (Control control in this.defaultControls)
                            control.Visible = true;
                    }
                }
            }
        }
    }
}

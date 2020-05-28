namespace BiblioSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signupButton = new System.Windows.Forms.Button();
            this.signupLabel = new System.Windows.Forms.Label();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwTextBox = new System.Windows.Forms.TextBox();
            this.passwLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signupButton
            // 
            this.signupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupButton.BackColor = System.Drawing.Color.Gainsboro;
            this.signupButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.signupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.signupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signupButton.Location = new System.Drawing.Point(41, 480);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(268, 39);
            this.signupButton.TabIndex = 16;
            this.signupButton.Text = "Создать аккаунт";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // signupLabel
            // 
            this.signupLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupLabel.AutoSize = true;
            this.signupLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signupLabel.Location = new System.Drawing.Point(38, 433);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(218, 18);
            this.signupLabel.TabIndex = 15;
            this.signupLabel.Text = "Ещё не зарегистрированы?";
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminRadioButton.Location = new System.Drawing.Point(41, 259);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(175, 21);
            this.adminRadioButton.TabIndex = 14;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Войти как оператор";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BackColor = System.Drawing.Color.Gainsboro;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(41, 312);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(268, 39);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwTextBox
            // 
            this.passwTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwTextBox.Location = new System.Drawing.Point(41, 202);
            this.passwTextBox.Name = "passwTextBox";
            this.passwTextBox.Size = new System.Drawing.Size(268, 27);
            this.passwTextBox.TabIndex = 12;
            this.passwTextBox.UseSystemPasswordChar = true;
            // 
            // passwLabel
            // 
            this.passwLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwLabel.AutoSize = true;
            this.passwLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwLabel.Location = new System.Drawing.Point(38, 167);
            this.passwLabel.Name = "passwLabel";
            this.passwLabel.Size = new System.Drawing.Size(65, 18);
            this.passwLabel.TabIndex = 11;
            this.passwLabel.Text = "Пароль";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(41, 106);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(268, 26);
            this.usernameTextBox.TabIndex = 10;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(38, 71);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(150, 18);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Имя пользователя";
            // 
            // LoginForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 591);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwTextBox);
            this.Controls.Add(this.passwLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwTextBox;
        private System.Windows.Forms.Label passwLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
    }
}
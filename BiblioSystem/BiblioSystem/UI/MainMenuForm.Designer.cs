namespace BiblioSystem
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.descrTextBox = new System.Windows.Forms.TextBox();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionPanel.SuspendLayout();
            this.mainMenuPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(3, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(337, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = " Библиографическая система";
            // 
            // descrTextBox
            // 
            this.descrTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descrTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.descrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descrTextBox.Enabled = false;
            this.descrTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descrTextBox.Location = new System.Drawing.Point(7, 55);
            this.descrTextBox.Multiline = true;
            this.descrTextBox.Name = "descrTextBox";
            this.descrTextBox.Size = new System.Drawing.Size(521, 75);
            this.descrTextBox.TabIndex = 1;
            this.descrTextBox.Text = "Библиографическая система предназначена для хранения сведений о публикациях, ссыл" +
    "ок между публикациями и расчёта библиометрического показателя – индекса цитирова" +
    "ния автора.";
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionPanel.AutoSize = true;
            this.descriptionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionPanel.Controls.Add(this.mainMenuPanel);
            this.descriptionPanel.Location = new System.Drawing.Point(151, 32);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(619, 590);
            this.descriptionPanel.TabIndex = 0;
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.titleLabel);
            this.mainMenuPanel.Controls.Add(this.descrTextBox);
            this.mainMenuPanel.Location = new System.Drawing.Point(35, 199);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(544, 162);
            this.mainMenuPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.AutoSize = true;
            this.rightPanel.BackColor = System.Drawing.SystemColors.Control;
            this.rightPanel.Controls.Add(this.menuStrip);
            this.rightPanel.Location = new System.Drawing.Point(791, 32);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(349, 591);
            this.rightPanel.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mainScreenMenuItem,
            this.pListMenuItem,
            this.indexMenuItem,
            this.citationMenuItem,
            this.logOutMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(349, 591);
            this.menuStrip.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(342, 20);
            // 
            // mainScreenMenuItem
            // 
            this.mainScreenMenuItem.AutoSize = false;
            this.mainScreenMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.mainScreenMenuItem.Name = "mainScreenMenuItem";
            this.mainScreenMenuItem.Size = new System.Drawing.Size(349, 50);
            this.mainScreenMenuItem.Text = "Главное меню";
            this.mainScreenMenuItem.Click += new System.EventHandler(this.mainScreenMenuItem_Click);
            // 
            // pListMenuItem
            // 
            this.pListMenuItem.AutoSize = false;
            this.pListMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pListMenuItem.Name = "pListMenuItem";
            this.pListMenuItem.Size = new System.Drawing.Size(349, 50);
            this.pListMenuItem.Text = "Список публикаций";
            this.pListMenuItem.Click += new System.EventHandler(this.pListMenuItem_Click);
            // 
            // indexMenuItem
            // 
            this.indexMenuItem.AutoSize = false;
            this.indexMenuItem.Name = "indexMenuItem";
            this.indexMenuItem.Size = new System.Drawing.Size(349, 50);
            this.indexMenuItem.Text = "Индекс цитирования";
            this.indexMenuItem.Click += new System.EventHandler(this.indexMenuItem_Click);
            // 
            // logOutMenuItem
            // 
            this.logOutMenuItem.AutoSize = false;
            this.logOutMenuItem.Name = "logOutMenuItem";
            this.logOutMenuItem.Size = new System.Drawing.Size(349, 50);
            this.logOutMenuItem.Text = "Выйти";
            this.logOutMenuItem.Click += new System.EventHandler(this.logOutMenuItem_Click);
            // 
            // citationMenuItem
            // 
            this.citationMenuItem.AutoSize = false;
            this.citationMenuItem.Name = "citationMenuItem";
            this.citationMenuItem.Size = new System.Drawing.Size(349, 50);
            this.citationMenuItem.Text = "Цитирования";
            this.citationMenuItem.Click += new System.EventHandler(this.citationMenuItem_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1280, 656);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.descriptionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainMenuForm";
            this.Text = "АИС \"Библиографическая система\"";
            this.descriptionPanel.ResumeLayout(false);
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox descrTextBox;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainScreenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citationMenuItem;
    }
}


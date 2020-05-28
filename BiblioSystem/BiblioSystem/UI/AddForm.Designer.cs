namespace BiblioSystem.UI
{
    partial class AddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.authorGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.citationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.citationGridView = new System.Windows.Forms.DataGridView();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.addCitationButton = new System.Windows.Forms.Button();
            this.addPublicationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новая публикация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название публикации";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(42, 121);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(532, 27);
            this.nameTextBox.TabIndex = 2;
            // 
            // authorGridView
            // 
            this.authorGridView.AllowUserToAddRows = false;
            this.authorGridView.AllowUserToDeleteRows = false;
            this.authorGridView.AllowUserToResizeColumns = false;
            this.authorGridView.AllowUserToResizeRows = false;
            this.authorGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.authorGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.authorGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.authorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.authorGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.authorGridView.Location = new System.Drawing.Point(42, 244);
            this.authorGridView.Name = "authorGridView";
            this.authorGridView.RowHeadersVisible = false;
            this.authorGridView.RowTemplate.Height = 30;
            this.authorGridView.RowTemplate.ReadOnly = true;
            this.authorGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.authorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authorGridView.Size = new System.Drawing.Size(532, 91);
            this.authorGridView.TabIndex = 3;
            this.authorGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.authorGridView_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите автора публикации";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(42, 193);
            this.authorTextBox.Multiline = true;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(477, 27);
            this.authorTextBox.TabIndex = 5;
            // 
            // citationTextBox
            // 
            this.citationTextBox.Location = new System.Drawing.Point(39, 379);
            this.citationTextBox.Multiline = true;
            this.citationTextBox.Name = "citationTextBox";
            this.citationTextBox.Size = new System.Drawing.Size(480, 27);
            this.citationTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите цитируемую публикацию";
            // 
            // citationGridView
            // 
            this.citationGridView.AllowUserToAddRows = false;
            this.citationGridView.AllowUserToDeleteRows = false;
            this.citationGridView.AllowUserToResizeColumns = false;
            this.citationGridView.AllowUserToResizeRows = false;
            this.citationGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.citationGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.citationGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.citationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.citationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citationGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.citationGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.citationGridView.Location = new System.Drawing.Point(39, 430);
            this.citationGridView.Name = "citationGridView";
            this.citationGridView.RowHeadersVisible = false;
            this.citationGridView.RowTemplate.Height = 30;
            this.citationGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.citationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.citationGridView.Size = new System.Drawing.Size(532, 91);
            this.citationGridView.TabIndex = 6;
            this.citationGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.citationGridView_Paint);
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addAuthorButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.addAuthorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.addAuthorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.addAuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAuthorButton.Location = new System.Drawing.Point(525, 193);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(49, 28);
            this.addAuthorButton.TabIndex = 9;
            this.addAuthorButton.Text = "+";
            this.addAuthorButton.UseVisualStyleBackColor = false;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // addCitationButton
            // 
            this.addCitationButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addCitationButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.addCitationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.addCitationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.addCitationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCitationButton.Location = new System.Drawing.Point(525, 379);
            this.addCitationButton.Name = "addCitationButton";
            this.addCitationButton.Size = new System.Drawing.Size(49, 28);
            this.addCitationButton.TabIndex = 10;
            this.addCitationButton.Text = "+";
            this.addCitationButton.UseVisualStyleBackColor = false;
            this.addCitationButton.Click += new System.EventHandler(this.addCitationButton_Click);
            // 
            // addPublicationButton
            // 
            this.addPublicationButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addPublicationButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.addPublicationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.addPublicationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.addPublicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPublicationButton.Location = new System.Drawing.Point(525, 50);
            this.addPublicationButton.Name = "addPublicationButton";
            this.addPublicationButton.Size = new System.Drawing.Size(49, 28);
            this.addPublicationButton.TabIndex = 11;
            this.addPublicationButton.Text = "+";
            this.addPublicationButton.UseVisualStyleBackColor = false;
            this.addPublicationButton.Click += new System.EventHandler(this.addPublicationButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 590);
            this.Controls.Add(this.addPublicationButton);
            this.Controls.Add(this.addCitationButton);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.citationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.citationGridView);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorGridView);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.authorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView authorGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox citationTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView citationGridView;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Button addCitationButton;
        private System.Windows.Forms.Button addPublicationButton;
    }
}
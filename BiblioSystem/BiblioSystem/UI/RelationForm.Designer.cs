namespace BiblioSystem.UI
{
    partial class RelationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.citationButton = new System.Windows.Forms.Button();
            this.ownGridView = new System.Windows.Forms.DataGridView();
            this.allGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ownGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваша публикация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Другие публикации";
            // 
            // citationButton
            // 
            this.citationButton.BackColor = System.Drawing.Color.Gainsboro;
            this.citationButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.citationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.citationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.citationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citationButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.citationButton.Location = new System.Drawing.Point(44, 489);
            this.citationButton.Name = "citationButton";
            this.citationButton.Size = new System.Drawing.Size(532, 27);
            this.citationButton.TabIndex = 2;
            this.citationButton.Text = "Добавить цитирование";
            this.citationButton.UseVisualStyleBackColor = false;
            this.citationButton.Click += new System.EventHandler(this.citationButton_Click);
            // 
            // ownGridView
            // 
            this.ownGridView.AllowUserToAddRows = false;
            this.ownGridView.AllowUserToDeleteRows = false;
            this.ownGridView.AllowUserToResizeColumns = false;
            this.ownGridView.AllowUserToResizeRows = false;
            this.ownGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ownGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ownGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ownGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ownGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ownGridView.EnableHeadersVisualStyles = false;
            this.ownGridView.Location = new System.Drawing.Point(44, 121);
            this.ownGridView.Name = "ownGridView";
            this.ownGridView.ReadOnly = true;
            this.ownGridView.RowHeadersVisible = false;
            this.ownGridView.RowTemplate.Height = 35;
            this.ownGridView.RowTemplate.ReadOnly = true;
            this.ownGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ownGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ownGridView.Size = new System.Drawing.Size(532, 143);
            this.ownGridView.TabIndex = 3;
            // 
            // allGridView
            // 
            this.allGridView.AllowUserToAddRows = false;
            this.allGridView.AllowUserToDeleteRows = false;
            this.allGridView.AllowUserToResizeColumns = false;
            this.allGridView.AllowUserToResizeRows = false;
            this.allGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.allGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.allGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.allGridView.EnableHeadersVisualStyles = false;
            this.allGridView.Location = new System.Drawing.Point(44, 325);
            this.allGridView.Name = "allGridView";
            this.allGridView.ReadOnly = true;
            this.allGridView.RowHeadersVisible = false;
            this.allGridView.RowTemplate.Height = 35;
            this.allGridView.RowTemplate.ReadOnly = true;
            this.allGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allGridView.Size = new System.Drawing.Size(532, 143);
            this.allGridView.TabIndex = 4;
            // 
            // RelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 590);
            this.Controls.Add(this.allGridView);
            this.Controls.Add(this.ownGridView);
            this.Controls.Add(this.citationButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelationForm";
            this.Text = "RelationForm";
            ((System.ComponentModel.ISupportInitialize)(this.ownGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button citationButton;
        private System.Windows.Forms.DataGridView ownGridView;
        private System.Windows.Forms.DataGridView allGridView;
    }
}
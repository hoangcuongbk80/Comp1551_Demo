namespace Lecture9
{
    partial class Form3
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
            bt1_save_file = new Button();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            start_date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bt1_save_file
            // 
            bt1_save_file.BackColor = SystemColors.ActiveCaption;
            bt1_save_file.Location = new Point(71, 728);
            bt1_save_file.Name = "bt1_save_file";
            bt1_save_file.Size = new Size(188, 58);
            bt1_save_file.TabIndex = 1;
            bt1_save_file.Text = "Save to File";
            bt1_save_file.UseVisualStyleBackColor = false;
            bt1_save_file.Click += bt1_save_file_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Salary, Role, start_date });
            dataGridView1.Location = new Point(71, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1089, 610);
            dataGridView1.TabIndex = 2;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 12;
            Name.Name = "Name";
            Name.Width = 250;
            // 
            // Salary
            // 
            Salary.HeaderText = "Salary";
            Salary.MinimumWidth = 12;
            Salary.Name = "Salary";
            Salary.Width = 250;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 12;
            Role.Name = "Role";
            Role.Width = 250;
            // 
            // start_date
            // 
            start_date.HeaderText = "Start Date";
            start_date.MinimumWidth = 12;
            start_date.Name = "start_date";
            start_date.Width = 250;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 827);
            Controls.Add(dataGridView1);
            Controls.Add(bt1_save_file);
            //Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button bt1_save_file;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn start_date;
    }
}
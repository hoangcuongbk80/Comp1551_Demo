namespace Lecture9
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            tb1_name = new TextBox();
            tb2_salary = new TextBox();
            label3 = new Label();
            label4 = new Label();
            roleComboBox = new ComboBox();
            startDatePicker1 = new DateTimePicker();
            label5 = new Label();
            bt1_Add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSalmon;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(372, 48);
            label1.Name = "label1";
            label1.Size = new Size(329, 64);
            label1.TabIndex = 0;
            label1.Text = "Employee Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 177);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // tb1_name
            // 
            tb1_name.Location = new Point(372, 177);
            tb1_name.Name = "tb1_name";
            tb1_name.Size = new Size(329, 47);
            tb1_name.TabIndex = 2;
            // 
            // tb2_salary
            // 
            tb2_salary.Location = new Point(372, 266);
            tb2_salary.Name = "tb2_salary";
            tb2_salary.Size = new Size(329, 47);
            tb2_salary.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 272);
            label3.Name = "label3";
            label3.Size = new Size(96, 41);
            label3.TabIndex = 4;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 359);
            label4.Name = "label4";
            label4.Size = new Size(76, 41);
            label4.TabIndex = 5;
            label4.Text = "Role";
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Manager", "Associate", "Admin", "Intern" });
            roleComboBox.Location = new Point(372, 359);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(329, 49);
            roleComboBox.TabIndex = 6;
            // 
            // startDatePicker1
            // 
            startDatePicker1.Location = new Point(372, 450);
            startDatePicker1.Name = "startDatePicker1";
            startDatePicker1.Size = new Size(530, 47);
            startDatePicker1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 455);
            label5.Name = "label5";
            label5.Size = new Size(145, 41);
            label5.TabIndex = 8;
            label5.Text = "Start date";
            // 
            // bt1_Add
            // 
            bt1_Add.BackColor = Color.FromArgb(192, 192, 0);
            bt1_Add.Location = new Point(372, 581);
            bt1_Add.Name = "bt1_Add";
            bt1_Add.Size = new Size(188, 58);
            bt1_Add.TabIndex = 9;
            bt1_Add.Text = "Add";
            bt1_Add.UseVisualStyleBackColor = false;
            bt1_Add.Click += bt1_Add_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 748);
            Controls.Add(bt1_Add);
            Controls.Add(label5);
            Controls.Add(startDatePicker1);
            Controls.Add(roleComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb2_salary);
            Controls.Add(tb1_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb1_name;
        private TextBox tb2_salary;
        private Label label3;
        private Label label4;
        private ComboBox roleComboBox;
        private DateTimePicker startDatePicker1;
        private Label label5;
        private Button bt1_Add;
    }
}
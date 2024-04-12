namespace Lecture9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt1_login = new Button();
            tb1_username = new TextBox();
            tb2_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bt1_login
            // 
            bt1_login.BackColor = SystemColors.ActiveCaption;
            bt1_login.Location = new Point(436, 393);
            bt1_login.Name = "bt1_login";
            bt1_login.Size = new Size(188, 58);
            bt1_login.TabIndex = 0;
            bt1_login.Text = "Login";
            bt1_login.UseVisualStyleBackColor = false;
            bt1_login.Click += bt1_login_Click;
            // 
            // tb1_username
            // 
            tb1_username.Location = new Point(376, 172);
            tb1_username.Name = "tb1_username";
            tb1_username.Size = new Size(317, 47);
            tb1_username.TabIndex = 1;
            // 
            // tb2_password
            // 
            tb2_password.Location = new Point(376, 269);
            tb2_password.Name = "tb2_password";
            tb2_password.Size = new Size(317, 47);
            tb2_password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 172);
            label1.Name = "label1";
            label1.Size = new Size(165, 41);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 269);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 731);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb2_password);
            Controls.Add(tb1_username);
            Controls.Add(bt1_login);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt1_login;
        private TextBox tb1_username;
        private TextBox tb2_password;
        private Label label1;
        private Label label2;
    }
}

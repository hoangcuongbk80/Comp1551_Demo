namespace Lecture10
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
            this.bt_inner_join = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_count = new System.Windows.Forms.Button();
            this.bt_max_min = new System.Windows.Forms.Button();
            this.bt_sum = new System.Windows.Forms.Button();
            this.bt_left_join = new System.Windows.Forms.Button();
            this.bt_right_join = new System.Windows.Forms.Button();
            this.bt_full_join = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_inner_join
            // 
            this.bt_inner_join.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_inner_join.Location = new System.Drawing.Point(29, 120);
            this.bt_inner_join.Name = "bt_inner_join";
            this.bt_inner_join.Size = new System.Drawing.Size(204, 65);
            this.bt_inner_join.TabIndex = 16;
            this.bt_inner_join.Text = "Inner Join";
            this.bt_inner_join.UseVisualStyleBackColor = false;
            this.bt_inner_join.Click += new System.EventHandler(this.bt_inner_join_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(542, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 714);
            this.dataGridView1.TabIndex = 15;
            // 
            // bt_count
            // 
            this.bt_count.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_count.Location = new System.Drawing.Point(76, 453);
            this.bt_count.Name = "bt_count";
            this.bt_count.Size = new System.Drawing.Size(379, 65);
            this.bt_count.TabIndex = 17;
            this.bt_count.Text = "Count";
            this.bt_count.UseVisualStyleBackColor = false;
            this.bt_count.Click += new System.EventHandler(this.bt_count_Click);
            // 
            // bt_max_min
            // 
            this.bt_max_min.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_max_min.Location = new System.Drawing.Point(76, 551);
            this.bt_max_min.Name = "bt_max_min";
            this.bt_max_min.Size = new System.Drawing.Size(379, 65);
            this.bt_max_min.TabIndex = 18;
            this.bt_max_min.Text = "Max Min";
            this.bt_max_min.UseVisualStyleBackColor = false;
            this.bt_max_min.Click += new System.EventHandler(this.bt_max_min_Click);
            // 
            // bt_sum
            // 
            this.bt_sum.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_sum.Location = new System.Drawing.Point(76, 648);
            this.bt_sum.Name = "bt_sum";
            this.bt_sum.Size = new System.Drawing.Size(379, 65);
            this.bt_sum.TabIndex = 19;
            this.bt_sum.Text = "Sum";
            this.bt_sum.UseVisualStyleBackColor = false;
            this.bt_sum.Click += new System.EventHandler(this.bt_sum_Click);
            // 
            // bt_left_join
            // 
            this.bt_left_join.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_left_join.Location = new System.Drawing.Point(291, 120);
            this.bt_left_join.Name = "bt_left_join";
            this.bt_left_join.Size = new System.Drawing.Size(204, 65);
            this.bt_left_join.TabIndex = 20;
            this.bt_left_join.Text = "Left Join";
            this.bt_left_join.UseVisualStyleBackColor = false;
            this.bt_left_join.Click += new System.EventHandler(this.bt_left_join_Click);
            // 
            // bt_right_join
            // 
            this.bt_right_join.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_right_join.Location = new System.Drawing.Point(29, 213);
            this.bt_right_join.Name = "bt_right_join";
            this.bt_right_join.Size = new System.Drawing.Size(204, 65);
            this.bt_right_join.TabIndex = 21;
            this.bt_right_join.Text = "Right Join";
            this.bt_right_join.UseVisualStyleBackColor = false;
            this.bt_right_join.Click += new System.EventHandler(this.bt_right_join_Click);
            // 
            // bt_full_join
            // 
            this.bt_full_join.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_full_join.Location = new System.Drawing.Point(291, 213);
            this.bt_full_join.Name = "bt_full_join";
            this.bt_full_join.Size = new System.Drawing.Size(204, 65);
            this.bt_full_join.TabIndex = 22;
            this.bt_full_join.Text = "Full Join";
            this.bt_full_join.UseVisualStyleBackColor = false;
            this.bt_full_join.Click += new System.EventHandler(this.bt_full_join_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 956);
            this.Controls.Add(this.bt_full_join);
            this.Controls.Add(this.bt_right_join);
            this.Controls.Add(this.bt_left_join);
            this.Controls.Add(this.bt_sum);
            this.Controls.Add(this.bt_max_min);
            this.Controls.Add(this.bt_count);
            this.Controls.Add(this.bt_inner_join);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_inner_join;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_count;
        private System.Windows.Forms.Button bt_max_min;
        private System.Windows.Forms.Button bt_sum;
        private System.Windows.Forms.Button bt_left_join;
        private System.Windows.Forms.Button bt_right_join;
        private System.Windows.Forms.Button bt_full_join;
    }
}
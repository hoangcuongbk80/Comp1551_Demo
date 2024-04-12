using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Display employee information
            foreach (Employee employee in EmployeeManager.Employees)
            {
                //listBox1.Items.Add($"{employee.Name}, {employee.Salary}, {employee.Role}, {employee.StartDate}");
                ///richTextBox1.Text += employee.Name + " " + employee.Salary + " " + employee.Role.ToString() + " " + employee.StartDate + "\n";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bt1_save_file_Click(object sender, EventArgs e)
        {
            StreamWriter myFile = new StreamWriter("employee.txt", true);
            //string employee_info = richTextBox1.Text;
            //myFile.Write(employee_info);
            myFile.Close();
        }

    }
}

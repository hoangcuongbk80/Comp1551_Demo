using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Display employee information
            foreach (Employee employee in EmployeeManager.Employees)
            {
                listBox1.Items.Add($"{employee.Name}, {employee.Salary}, {employee.Role}, {employee.StartDate}");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

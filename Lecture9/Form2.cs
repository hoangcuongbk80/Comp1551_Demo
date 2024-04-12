using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void bt1_Add_Click(object sender, EventArgs e)
        {
            string name = tb1_name.Text;
            // Validate name
            if (!IsValidName(name))
            {
                MessageBox.Show("Invalid name. Name should consist of letters only.");
                return;
            }

            double salary;
            if (!double.TryParse(tb2_salary.Text, out salary))
            {
                MessageBox.Show("Invalid salary. Please enter a valid number.");
                return;
            }

            Role role;
            if (!Enum.TryParse(roleComboBox.SelectedItem.ToString(), out role))
            {
                MessageBox.Show("Invalid role. Please select a valid role.");
                return;
            }

            DateTime startDate = startDatePicker1.Value;
            if (startDate > DateTime.Now)
            {
                MessageBox.Show("Start date cannot be in the future.");
                return;
            }

            // Create the employee object
            Employee newEmployee = new Employee
            {
                Name = name,
                Salary = salary,
                Role = role,
                StartDate = startDate
            };

            // Add the employee to the EmployeeManager
            EmployeeManager.AddEmployee(newEmployee);

            // Clear input fields
            tb1_name.Clear();
            tb2_salary.Clear();
            roleComboBox.SelectedIndex = -1;
            startDatePicker1.Value = DateTime.Now;

            MessageBox.Show("Employee information added successfully.");
            // Display Form3 after adding employee
            Form3 form3 = new Form3();
            form3.Show();
        }

        private bool IsValidName(string name)
        {
            // Use regular expression to check if name consists of letters only
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }
    }
}

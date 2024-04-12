using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            employeeBindingSource.AddNew();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.RemoveCurrent();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string searchTerm = tb_search_term.Text;
            if (cb_search.Text == "Name")
            {
                var query = database1DataSet.Employee.Where(emp => emp.Name.Contains(searchTerm));
                employeeBindingSource.DataSource = query.ToList();
            }
            else if (cb_search.Text == "Role")
            {
                var query = database1DataSet.Employee.Where(emp => emp.Role.Contains(searchTerm));
                employeeBindingSource.DataSource = query.ToList();
            }
            else if(cb_search.Text == "Salary")
            {
                if (int.TryParse(searchTerm, out int salary))
                {
                    var query = database1DataSet.Employee.Where(emp => emp.Salary == salary);
                    employeeBindingSource.DataSource = query.ToList();
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer value for the salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(cb_search.Text == "Start Date")
            {
                if (DateTime.TryParse(searchTerm, out DateTime startDate))
                {
                    var query = database1DataSet.Employee.Where(emp => emp.Date.Date == startDate.Date);
                    employeeBindingSource.DataSource = query.ToList();
                }
                else
                {
                    MessageBox.Show("Please enter a valid date for the start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Something wrong, please double check the provided info!");
            }
        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void bt_inner_join_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Code\Database_CO1102\Database_CO1102\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT e.Name, e.Salary, e.Role, e.Date, d.DepartmentName " +
                                   "FROM Employee e " +
                                   "INNER JOIN Department d ON e.DepartmentId = d.DepartmentId";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bt_left_join_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Code\Comp1551_Demo\Lecture10\Database1.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT e.Name, e.Salary, e.Role, e.Date, d.DepartmentName " +
                                   "FROM Employee e " +
                                   "LEFT JOIN Department d ON e.DepartmentId = d.DepartmentId";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bt_right_join_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Code\Comp1551_Demo\Lecture10\Database1.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT e.Name, e.Salary, e.Role, e.Date, d.DepartmentName " +
                                   "FROM Employee e " +
                                   "RIGHT JOIN Department d ON e.DepartmentId = d.DepartmentId";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void bt_full_join_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Code\Comp1551_Demo\Lecture10\Database1.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT e.Name, e.Salary, e.Role, e.Date, d.DepartmentName " +
                                   "FROM Employee e " +
                                   "FULL JOIN Department d ON e.DepartmentId = d.DepartmentId";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void bt_count_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Code\Comp1551_Demo\Lecture10\Database1.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string countQuery = "SELECT d.DepartmentName, COUNT(e.Name) AS EmployeeCount " +
                                        "FROM Department d " +
                                        "LEFT JOIN Employee e ON d.DepartmentId = e.DepartmentId " +
                                        "GROUP BY d.DepartmentName";
                    SqlDataAdapter countAdapter = new SqlDataAdapter(countQuery, connection);
                    DataTable countTable = new DataTable();
                    countAdapter.Fill(countTable);

                    dataGridView1.DataSource = countTable; // Display Employee count by Department

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void bt_max_min_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Code\Comp1551_Demo\Lecture10\Database1.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string minMaxQuery = "SELECT d.DepartmentName, MIN(e.Salary) AS MinSalary, MAX(e.Salary) AS MaxSalary " +
                                         "FROM Department d " +
                                         "LEFT JOIN Employee e ON d.DepartmentId = e.DepartmentId " +
                                         "GROUP BY d.DepartmentName";
                    SqlDataAdapter minMaxAdapter = new SqlDataAdapter(minMaxQuery, connection);
                    DataTable minMaxTable = new DataTable();
                    minMaxAdapter.Fill(minMaxTable);

                    dataGridView1.DataSource = minMaxTable; // Display Min and Max Salary by Department

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bt_sum_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FGW\Courses\COMP1551-ApplicationDevelopment\Code\Comp1551_Demo\Lecture10\Database1.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Example 3: Total Salary and Average Salary for all Employees
                    string salaryAggQuery = "SELECT SUM(Salary) AS TotalSalary, AVG(Salary) AS AvgSalary " +
                                            "FROM Employee";
                    SqlDataAdapter salaryAggAdapter = new SqlDataAdapter(salaryAggQuery, connection);
                    DataTable salaryAggTable = new DataTable();
                    salaryAggAdapter.Fill(salaryAggTable);

                    dataGridView1.DataSource = salaryAggTable; // Display Total and Average Salary

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

       
    }
}

using System;

namespace Lecture8
{
    public enum Role
    {
        Manager,
        Associate,
        Admin,
        Intern
    }

    public class Employee
    {
        private string name = "";
        private double salary;
        private Role role;
        private DateTime startDate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 10000 && value < 100000)
                {
                    salary = value;
                }
            }
        }

        public Role Role
        {
            get { return role; }
            set { role = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                if (value <= DateTime.Now)
                {
                    startDate = value;
                }
                else
                {
                    Console.WriteLine("Start date cannot be in the future.");
                }
            }
        }
    }

    public static class EmployeeManager
    {
        private static List<Employee> employees = new List<Employee>();

        public static List<Employee> Employees
        {
            get { return employees; }
        }

        public static void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}

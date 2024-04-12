using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    enum EmployeeRole
    {
        Manager,
        Developer,
        QAEngineer,
        Designer
    }

    // Employee class representing a generic employee
    class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public EmployeeRole Role { get; set; }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine();
        }
    }
    internal class Enum
    {
        static void Main1()
        {
            /*Days today = Days.Wednesday;
            Console.WriteLine("Today is: " + today);*/

            Employee manager = new Employee { EmployeeID = 1, Name = "John Manager", Role = EmployeeRole.Manager };
            Employee developer = new Employee { EmployeeID = 2, Name = "Alice Developer", Role = EmployeeRole.Developer };
            Employee qaEngineer = new Employee { EmployeeID = 3, Name = "Bob QA Engineer", Role = EmployeeRole.QAEngineer };
            Console.WriteLine("Employee Details:");
            manager.DisplayEmployeeDetails();
            developer.DisplayEmployeeDetails();
            qaEngineer.DisplayEmployeeDetails();
        }
    }
}
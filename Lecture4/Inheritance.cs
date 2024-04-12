using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    // Base class representing a person
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        }
    }

    // Derived class representing a student, inheriting from the Person class
    public class Student : Person
    {
        public string StudentId { get; set; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string studentId)
            : base(firstName, lastName, dateOfBirth)
        {
            StudentId = studentId;
        }

        public void Study()
        {
            Console.WriteLine($"Student {FirstName} is studying.");
        }
    }

    // Derived class representing a teacher, inheriting from the Person class
    public class Teacher : Person
    {
        public string EmployeeId { get; set; }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, string employeeId)
            : base(firstName, lastName, dateOfBirth)
        {
            EmployeeId = employeeId;
        }

        public void Teach()
        {
            Console.WriteLine($"Teacher {FirstName} is teaching.");
        }
    }

    class TestInherit
    {
        static void Main1()
        {
            // Create instances of derived classes
            Student student = new Student("John", "Doe", new DateTime(2000, 5, 15), "S12345");
            Teacher teacher = new Teacher("Alice", "Smith", new DateTime(1985, 8, 10), "T98765");

            // Use inherited and specific methods and properties
            student.DisplayDetails();
            student.Study();

            Console.WriteLine();

            teacher.DisplayDetails();
            teacher.Teach();
        }
    }
}

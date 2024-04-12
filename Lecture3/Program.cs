namespace Lecture3
{
    public class Person
    {
        public string name;
        public int id;

        public void get_inf()
        {
            Console.WriteLine("Name: {0}, ID: {1}", name, id);
        }

    }

    class Student : Person
    {
        public string student_id;

        public void get_student_info()
        {
            Console.WriteLine("Name {0}, Student ID: {1}", name, student_id);
        }
    }
    static class Calculator
    {
        public static double add(double a, double b)
        {
            return a + b;
        }
        public static double sub(double a, double b)
        {
            return a - b;
        }

        public static double mul(double a, double b)
        {
            return a * b;
        }
        public static double? div(double a, double b)
        {
            if (b == 0)
                return null;
            else
                return a / b;
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter an double a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an double b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator (+ - * /): ");
            string opr = Convert.ToString(Console.ReadLine());

            double result;

            if (opr == "+")
            {
                result = Calculator.add(a, b);
                Console.WriteLine("a+b={0}", result);
            }
            if (opr == "-")
            {
                result = Calculator.sub(a, b);
                Console.WriteLine("a-b={0}", result);
            }
            if (opr == "*")
            {
                result = Calculator.mul(a, b);
                Console.WriteLine("a*b={0}", result);
            }
            if (opr == "/")
            {
                double? r = Calculator.div(a, b);
                Console.WriteLine("a/b={0}", r);
            }

            Console.WriteLine("Hello, World!");
            Person person1 = new Person();
            person1.name = "Cuong";
            person1.id = 123456;
            person1.get_inf();

            Student student1 = new Student();
            student1.name = "Binh";
            student1.student_id = "GCH123456";
            student1.get_student_info();
        }
    }
}

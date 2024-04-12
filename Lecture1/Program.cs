namespace Lecture1
{
    internal class Program
    {
        static public double SquareRoot(double Result)
        {
            return (Math.Sqrt(Result));
        }
        static public void Task1()
        {
            Console.WriteLine("----Task 1-------");
            Console.WriteLine(SquareRoot(16));
        }
        static public void Task2()
        {
            Console.WriteLine("----Task 2-------");
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(SquareRoot(num));
        }
        static public void Task3()
        {
            Console.WriteLine("----Task 3-------");
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine(SquareRoot(num));
            }
            else
            {
                Console.WriteLine("Negative Number!");
            }
        }

        static public void QuadraticEquation(double a, double b, double c)
        {
            double x1, x2, D;
            D = Convert.ToDouble(b * b - 4 * a * c);
            if ((a != 0) & (D >= 0))
            {
                x1 = Convert.ToDouble((-b + Math.Sqrt(D)) / (2 * a));
                x2 = Convert.ToDouble((-b - Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("The result is: {0} and {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("No solutions");
            }
        }
        static public void Task4()
        {
            Console.WriteLine("----Task 4-------");
            double v1, v2, v3;
            Console.WriteLine("Enter values for a, b and c:");
            v1 = Convert.ToDouble(Console.ReadLine());
            v2 = Convert.ToDouble(Console.ReadLine());
            v3 = Convert.ToDouble(Console.ReadLine());
            QuadraticEquation(v1, v2, v3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Task1();
            //Task2();
            //Task3();
            //Task4();
        }
    }
}

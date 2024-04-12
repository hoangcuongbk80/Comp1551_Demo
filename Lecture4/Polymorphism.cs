using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    class TestPoly
    {
        static void Main1()
        {
            Calculator calculator = new Calculator();

            // Method Overloading
            int sumInt = calculator.Add(5, 10);
            double sumDouble = calculator.Add(5.5, 10.5);

            Console.WriteLine($"Sum of integers: {sumInt}");
            Console.WriteLine($"Sum of doubles: {sumDouble}");
        }
    }

}

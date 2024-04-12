using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    // Generic class with a sorting method
    class SortingUtility<T> where T : IComparable<T>
    {
        public void SortArray(T[] array)
        {
            // Using a simple bubble sort algorithm for illustration
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        // Swap elements if they are in the wrong order
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
    internal class Generics
    {
        static public int Addition(int a, int b)
        { return a + b; }
        static public double Addition(double a, double b) {  return a + b; }

        static public void Swap(ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }
        static public void Swap(ref double a, ref double b)
        {
            double temp = a; a = b; b = temp;
        }
        static void Main1()
        {
            Addition(1, 2);
            Addition(1.5, 3.5);

            int a = 1, b = 2;
            Generics.Swap(ref a, ref b);
            Console.WriteLine("a={0} b={1}", a, b);

            double x = 1.5, y = 2.5;
            Generics.Swap(ref x, ref y);
            Console.WriteLine("x={0} y={1}", x, y);

            // Sorting an array of integers
            int[] intArray = { 4, 2, 8, 1, 5 };
            SortingUtility<int> intSorter = new SortingUtility<int>();
            intSorter.SortArray(intArray);

            // Sorting an array of strings
            string[] stringArray = { "apple", "orange", "banana", "grape", "kiwi" };
            SortingUtility<string> stringSorter = new SortingUtility<string>();
            stringSorter.SortArray(stringArray);

            // Displaying sorted arrays
            Console.WriteLine("Sorted Integer Array:");
            DisplayArray(intArray);

            Console.WriteLine("\nSorted String Array:");
            DisplayArray(stringArray);
        }

        // Generic method to display elements of an array
        static void DisplayArray<T>(T[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}

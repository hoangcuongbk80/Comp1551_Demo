using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    // Abstract class representing a geometric shape
    public abstract class Shape
    {
        // Abstract method to calculate the area of the shape
        public abstract double CalculateArea();

        // Concrete method to display information about the shape
        public void DisplayInfo()
        {
            Console.WriteLine($"This is a {GetType().Name} with an area of {CalculateArea()} square units.");
        }
    }

    // Interface defining the contract for shapes with a perimeter
    public interface IShapeWithPerimeter
    {
        double CalculatePerimeter();
    }

    // Concrete class representing a circle
    public class Circle : Shape, IShapeWithPerimeter
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Concrete class representing a rectangle
    public class Rectangle : Shape, IShapeWithPerimeter
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    class TestAbstract
    {
        static void Main1()
        {
            // Create instances of geometric shapes
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            // Use abstraction to calculate area and display information
            circle.DisplayInfo();
            rectangle.DisplayInfo();

            // Use the interface to calculate perimeter
            Console.WriteLine($"The perimeter of the circle is: {circle.CalculatePerimeter()}");
            Console.WriteLine($"The perimeter of the rectangle is: {rectangle.CalculatePerimeter()}");
        }
    }
}

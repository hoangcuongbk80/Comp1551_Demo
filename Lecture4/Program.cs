namespace Lecture4
{
    class MonthName
    {
        protected int month = 1;
        public int Month
        {
            get { return month; }
            set { if((value>0) && (value < 13)) {month = value;} }
        }
    }
    class QuadraticEquation
    {
        public double a;
        public double b;
        public double c;
        public double D;
        public double? x1;
        public double? x2;

        public void Calculate(double p1, double p2, double p3)
        {
            a=p1; b=p2; c=p3;
            D = Convert.ToDouble(b*b-4*a*c);
            if((a!=0) && (D>=0))
            {
                x1 = Convert.ToDouble((-b+Math.Sqrt(D))/(2*a));
                x2 = Convert.ToDouble((-b - Math.Sqrt(D)) / (2 * a));
            }
            else
            {
                x1 = null; x2=null;
            }
        }
    }
    class Vehicle
    {
        public Vehicle() { Console.WriteLine("This is a vehicle");}
        public void Say() { Console.WriteLine("Vehicle");}
    }
    class Car : Vehicle 
    {
        public Car() { Console.WriteLine("This is a car"); }
        public new void Say() { Console.WriteLine("Car"); }
    }
    class Toyota : Car
    {
        public Toyota() { Console.WriteLine("This is Toyota"); }
        public new void Say() { Console.WriteLine("Toyota"); }
    }
    class Vios : Toyota
    {
        public Vios() { Console.WriteLine("This is Prius"); }
        public new void Say() { Console.WriteLine("Toyota"); }
    }
    class MyClass
    {
        public void Call(int p)
        {
            Console.WriteLine("This is an integer");
        }
        public void Call(double p)
        {
            Console.WriteLine("This is a real number");
        }
        public void call(char p)
        {
            Console.WriteLine("This is a letter");
        }
        public void Call(string p)
        {
            Console.WriteLine("This is a text");
        }
    }
    abstract class BaseClass
    {
        public abstract void Say(); 
    }
    class DerivedClassA : BaseClass
    {
        public override void Say() { Console.WriteLine("Drived Class A"); }
    }
    class DerivedClassB : BaseClass
    {
        public override void Say(){ Console.WriteLine("Drived Class B");}
    }
    internal class Program : MonthName
    {
        static void Main(string[] args)
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

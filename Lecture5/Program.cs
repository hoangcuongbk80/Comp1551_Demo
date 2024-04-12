namespace Lecture5
{
    class Person
    {
        private string FirstName = "";
        private string LastName = "";

        public string getFirstName()
        {
            return FirstName;
        }
        public string getLastName()
        {
            return LastName;
        }
        public void setFirstName(string FN) 
        {
            FirstName = FN;
        }
        public void setLastName(string LN)
        {
            LastName = LN;
        }  
    }
    internal class Program
    {
        public enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static void Swap<T>(ref T Left, ref T Right)
        {
            T Temp;
            Temp = Left;
            Left = Right;
            Right = Temp;
        }
        static T Addition<T>(T Left, T Right)
        {
            dynamic X = Left;
            dynamic Y = Right;
            dynamic Z = X + Y;
            return (Z);
        }
        static void Main(string[] args)
        {
            /*Seasons MySeason;
            MySeason = Seasons.Spring;
            Console.WriteLine(MySeason);

            MySeason = (Seasons)0;
            Console.WriteLine(MySeason);

            MySeason = MySeason + 1;
            Console.WriteLine(MySeason);*/

            /*int L = 5;
            int R=10;
            Console.WriteLine("1. Left: {0}, Right: {1}", L, R);
            Swap<int>(ref L, ref R);
            Console.WriteLine("1. Left: {0}, Right: {1}", L, R);

            string First = "First";
            string Second = "Second";
            Console.WriteLine("1. Left: {0}, Right: {1}", First, Second);
            Swap<string>(ref First, ref Second);
            Console.WriteLine("1. Left: {0}, Right: {1}", First, Second);

            Console.WriteLine("{0}+{1}={2}", L, R, Addition<int>(L,R));*/

            /*int i;
            Person[] People = new Person[10];
            for(i = 0; i < 10; i++)
            {
                People[i] = new Person();
            }
            People[0].setFirstName("John");
            People[0].setLastName("Smith");
            People[1].setFirstName("Ann");
            People[1].setLastName("Jones");
            i = 1;
            foreach(Person a in People)
            {
                Console.WriteLine("{0} {1} {2}", i, a.getFirstName(), a.getLastName());
                i=i+1;
            }

            List<Person> MyList = new List<Person>();
            MyList.Add(People[0]);
            MyList.Add(People[1]);
            MyList.Add(People[2]);
            i = 1;
            foreach(Person b in MyList)
            {
                Console.WriteLine("{0} {1} {2}", i, b.getFirstName(), b.getLastName());
                i = i + 1;
            }*/

            /*DateTime a = new DateTime();
            Console.WriteLine(a.ToLongDateString());

            DateTime b = new DateTime(2020,2,2);
            Console.WriteLine(b.ToLongDateString());

            DateTime c = new DateTime(2020,1,1,16,30,0);
            Console.WriteLine(c.ToLongDateString());
            Console.WriteLine(a.ToLongTimeString());

            DateTime d = new DateTime();
            d=DateTime.Now;
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());*/

            // Utilize List<T> instead of an array
            List<Animal> animalsList = new List<Animal>();

            // Initialize the list with instances of derived classes
            animalsList.Add(new Dog("Buddy"));
            animalsList.Add(new Cat("Whiskers"));
            animalsList.Add(new Dog("Max"));

            // Utilize the class methods and data
            foreach (var animal in animalsList)
            {
                Console.WriteLine($"Name: {animal.Name}");
                animal.MakeSound();

                // Optional: Access specific methods of derived classes
                if (animal is Dog)
                {
                    Console.WriteLine("Special Dog-related action here");
                }
                else if (animal is Cat)
                {
                    Console.WriteLine("Special Cat-related action here");
                }

                Console.WriteLine();
            }
        }
    }
}
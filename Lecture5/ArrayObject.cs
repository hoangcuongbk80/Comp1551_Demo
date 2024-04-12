using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
    internal class ArrayObject
    {
        static void Main1()
        {
            // Step 2: Declare an array, the type of the array is the class
            Animal[] animals = new Animal[3];

            // Step 3: Initialize the array
            animals[0] = new Dog("Buddy");
            animals[1] = new Cat("Whiskers");
            animals[2] = new Dog("Max");

            // Step 4: Utilize the class methods and data
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}");
                animal.MakeSound();
                Console.WriteLine();
            }
        }
        static void Main2()
        {
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

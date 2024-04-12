using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
        class Nissan : Vehicle
        {
            public Nissan()
            {
                Console.WriteLine("Constructor of class Nissan");
            }
            // Providing new implementation of the "Say" method
            public new string Say()
            {
                string S;
                S = this.GetType().Name;
                return ("This vehicle is " + S);
            }
        }
        class Leaf : Nissan
        {
            public Leaf()
            {
            Console.WriteLine("Constructor of class Leaf");
        }
        public new string Say()
        {
            String S1 = Convert.ToString(this.GetType().BaseType.Name);
            String S2 = Convert.ToString(this.GetType().Name);
            return ("The name of this vehicle is " + S1 + " " + S2);
        }
    }
    class Almera : Nissan
    {
        public Almera()
        {
            Console.WriteLine("Constructor of class Almera");
        }
        public new string Say()
        {
            String S1 = Convert.ToString(this.GetType().BaseType.Name);
            String S2 = Convert.ToString(this.GetType().Name);
            return ("The name of this vehicle is " + S1 + " " + S2);
        }
    }
    class Terra : Nissan
    {
        public Terra()
        {
            Console.WriteLine("Constructor of class Terra");
        }
        // If "Say" method is not implemented in this class
        // then the Say" method from the base class "Nissan" will be invoked
    }
}

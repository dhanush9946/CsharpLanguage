using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class MultilevelInheritance
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }
        }
        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Barking...");

            }
        }
        class Puppy : Dog
        {
            public void Weep()
            {
                Console.WriteLine("Weeping...");
            }
        }

        public static void Main25()
        {
            Puppy p = new Puppy();
            p.Eat();
            p.Bark();
            p.Weep();
        }
    }
}

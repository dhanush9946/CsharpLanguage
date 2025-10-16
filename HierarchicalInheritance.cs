using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class HierarchicalInheritance
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
        class Cat:Animal
        {
            public void Meow()
            {
                Console.WriteLine("Meowing...");
            }
        }

        public static void Main26()
        {
            Cat c = new Cat();
            c.Eat();
            c.Meow();

            Dog d = new Dog();
            d.Eat();
            d.Bark();
        }
    }
}

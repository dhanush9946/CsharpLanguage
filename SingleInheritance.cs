using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class SingleInheritance
    {
        class Animals
        {
            public  void Eat()
            {
                Console.WriteLine("Eating...");
            }
        }
        class Dog : Animals
        {
            public void Bark()
            {
                Console.WriteLine("Braking...");
            }
        }
        public static void Main24()
        {
            Dog d = new Dog();
            d.Eat();
            d.Bark();
        }
    }
}

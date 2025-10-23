using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
     class Inheritance
    {

        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Dog is Eating...");
            }
        }
            class Dog : Animal
            {
                public void Bark()
                {
                    Console.WriteLine("Dog is Barking");

                }
            }
            public static void Main19()
            {
                Dog d = new Dog();
                d.Eat();
                d.Bark();
            }
      }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Abstraction
    {
        abstract class Vehicle
        {
            public abstract void Start();
        }
        class Bike : Vehicle
        {
            public override void Start()
            {
                Console.WriteLine("Bike start with a key");
            }
        }
        public static void Main21()
        {
            Vehicle v = new Bike();
            v.Start();
        }
    }
}

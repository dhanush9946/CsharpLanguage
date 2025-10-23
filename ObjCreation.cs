using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class ObjCreation
    {
         class Car
        {
            public string Brand;
            public string Color;
            public int Speed;

            public void Drive()
            {
                Console.WriteLine($"{Brand} is driving at {Speed}km/h with {Color} color");
            }
        }
        public class Program
        {
            public static void Main23()
            {
                Car car1 = new Car();
                car1.Brand = "BMW";
                car1.Color = "red";
                car1.Speed = 100;
                car1.Drive();

                Car car2 = new Car();
                car2.Brand = "Tesla";
                car2.Color = "Black";
                car2.Speed = 150;
                car2.Drive();
            }
        }
    }
}

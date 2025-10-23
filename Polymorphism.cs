using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Polymorphism
    {
        class Shape
        {
            public  virtual void Draw()
            {
                Console.WriteLine("Drawing shape");
            }
        }
        class Circle : Shape
        {
            public  override void Draw()
            {
                Console.WriteLine("Drawing a Circle");
            }
        }
        class Square : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Deawing a square");
            }
        }

        public static void Main20()
        {
            Shape s1 = new Circle();
            Shape s2 = new Square();

            s1.Draw();
            s2.Draw();
        }
    }
}

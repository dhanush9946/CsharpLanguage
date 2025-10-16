using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Hybrid
    {
        interface IA
        {
            void showA();
        }
        class Base
        {
            public void BaseMethod()
            {
                Console.WriteLine("base method");
            }
        }
        class Derived1 : Base, IA
        {
            public void showA()
            {
                Console.WriteLine("Form A");
            }
        }
        class Derived2 : Derived1
        {
            public void AnotherMethod()
            {
                Console.WriteLine("Another method");
            }
        }
        public static void Main29()
        {
            Derived2 d = new Derived2();
            d.showA();
            d.BaseMethod();
            d.AnotherMethod();
        }
    }
}

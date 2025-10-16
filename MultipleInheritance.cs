using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class MultipleInheritance
    {
        interface IA
        {
            void showA();
        }
        interface IB
        {
            void showB();
        }
        class C : IA, IB
        {
            public void showA()
            {
                Console.WriteLine("Form A");
            }
            public void showB()
            {
                Console.WriteLine("Form B");
            }
        }
        public static void Main27()
        {
            C c = new C();
            c.showA();
            c.showB();
        }
    }
}

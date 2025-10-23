using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class OddEven
    {
        public void Check(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is a Even number");
            }
            else
            {
                Console.WriteLine($"{a} is a Odd number");
            }
        }
    }
    class Program5
    {
       public static void Main56()
        {
            OddEven o = new OddEven();
            
            o.Check(7);
        }
    }
}

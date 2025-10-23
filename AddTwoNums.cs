using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Adding
    {
        public int a;
        public int b;

        public  int Add(int a,int b)
        {
            return a + b;

        }
    }
   public class Program3
    {
        public static void Main36()
        {
            Adding add=new Adding();
            add.a = 1;
            add.b = 2;
            Console.WriteLine(add.Add(1,2));
        }
    }
    
}

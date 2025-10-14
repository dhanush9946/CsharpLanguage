using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Prime
    {
        public static bool Main16()
        {
            Console.WriteLine("Enter the number:");
             int a = Convert.ToInt32(Console.ReadLine());

           

            for(int i = 2; i<a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
                
            }
            return true;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Diamond
    {
        public static void Main17()
        {
            for(int i = 0; i < 6; i++)
            {
                for(int j = i; j < 6; j++)
                {
                    Console.Write("  ");
                }
                for(int k = 0; k < 2*i-1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }
            for(int i = 4; i > 0; i--)
            {
                for(int j = 6; j > i; j--)
                {
                    Console.Write("  ");
                }
                for(int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Array
    {
        public static void Main15()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, };
            Console.WriteLine(numbers[0]);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}

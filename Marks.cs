using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Marks
    {
        public static void Main46()
        {
            List<int> marks = new List<int>() { 2, 3, 5, 6, 55, 33, 32, 56, };

            var max = marks.OrderByDescending(i => i).First();
            Console.WriteLine(max);

        }
    }
}

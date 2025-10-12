using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Function
    {
        public static void Main11()
        {
            void GetSquare(int num, out int result)
            {
                result = num * num;
            }
            int square;
            GetSquare(5, out square);
            Console.WriteLine(square);
        }
    }
}

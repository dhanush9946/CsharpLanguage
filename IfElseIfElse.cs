using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class IfElseIfElse
    {
        public static void Main4()
        {
            int score = 90;
            if (score >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (score >= 75)
            {
                Console.WriteLine("Grade B");
            }
            else
            {
                Console.WriteLine("Grade C");
            }
        }
    }
}

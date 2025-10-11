using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class SwitchCase
    {
        public static void Main5()
        {
            int day = 1;
            //switch (day)
            //{
            //    case 1:Console.WriteLine("Monday");break;
            //    case 2:Console.WriteLine("Tuesday");break;
            //    case 3:Console.WriteLine("Wednesday");break;
            //    default:Console.WriteLine("Invalid day");break;
            //}
            string result = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                _ => "Invalid"
            };

            Console.WriteLine(result);
        }
    }
}

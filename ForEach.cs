using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class ForEach
    {
        public static void Main7()
        {
            string[] names = { "Dhanush", "Arun", "Manu" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

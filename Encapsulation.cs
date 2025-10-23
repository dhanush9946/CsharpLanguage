using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Encapsulation
    {
        class Student
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        public static void Main22()
        {
            Student s = new Student();
            s.Name = "Dhanush";
            Console.WriteLine(s.Name);
        }
    }
}

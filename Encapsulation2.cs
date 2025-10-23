using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Encapsulation2
    {
        class Student
        {
            private string name;
            public  string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (value.Length > 0)

                        name = value;
                    else
                        Console.WriteLine("Name cannot be empty");
                }
            }
        }
        public static void Main30()
        {
            Student s = new Student();
            s.Name = "Dhanush";
            Console.WriteLine(s.Name);

            s.Name = "";
        }
    }
}

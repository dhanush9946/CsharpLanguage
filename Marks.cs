using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Marks
    {
        class Students
        {
            public string? Name { get; set; }
            public int Mark { get; set; }
        }
        public static void Main46()
        {
            List<Students> marks = new List<Students>()
            {
                new Students {Name="Dhanush",Mark=90},
                new Students{Name="john",Mark=36}

            };
            var high = marks.OrderByDescending(i => i.Mark).First();
            Console.WriteLine($"Higher mark is:{high.Mark}");

            

        }
    }
}

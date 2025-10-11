using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class ParallelForEach
    {
       
            public static void Main8()
            {
                var numbers = new List<int> { 1, 2, 3, 4, 5 };
                Parallel.ForEach(numbers, num =>
                {
                    Console.WriteLine($"Processing {num} on thread {Task.CurrentId}");
                });
            }
        }
    }


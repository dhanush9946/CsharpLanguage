using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstConsoleApp
{
    internal class Review
    {
        public static void Main50()
        {
            //var students = new Dictionary<int, string>
            //{
            //    {1,"Dhanush"},
            //    {2,"Arun"}
            //};
            //Console.WriteLine(students[1]);


            //Dictionary<int, string> students = new Dictionary<int, string>();
            //students.Add(1, "Dhanush");
            //students.Add(2, "Manu");
            //Console.WriteLine(students[1]);

            int[] numbers = { 1, 3,59,79,4, 2, };
            //System.Array.Reverse(numbers);
            //Console.WriteLine(string.Join(",",numbers));

            int[] copy = new int[numbers.Length];
            System.Array.Copy(numbers, copy, numbers.Length);
            Console.WriteLine(string.Join(",", copy));

        }
    }
}

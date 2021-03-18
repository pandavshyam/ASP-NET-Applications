using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignments
{
    /*
    Create a list of numbers {10, 50, 30, 60, 20, 70, 40, 100, 80, 90, 50, 30, 70, 20}, and perform following operations on list.

        a) print sorted list of number

        b) print distinct number from list 
    */
    class Problem1
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {10, 50, 30, 60, 20, 70, 40, 100, 80, 90, 50, 30, 70, 20};
            Console.WriteLine("List Before Sorting: ");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Sorting list using extension method
            list.Sort();
            Console.WriteLine("List after Sorting : ");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Sorting list using LINQ Query
            var sortedListUsingLinq = from i in list
                                      orderby i
                                      select i;
            Console.WriteLine("Using LINQ");
            foreach (var item in sortedListUsingLinq)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Printing distinct int from list
            // Printing using extension method
            IEnumerable<int> distinctList = list.Distinct();

            Console.WriteLine("Distinct Elements");
            foreach (var item in distinctList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Using LINSQ Query
            var sorted = (from item in list
                         select item).Distinct();
            Console.WriteLine("Distinct Elements LINQ");
            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

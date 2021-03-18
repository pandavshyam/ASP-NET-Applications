using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignments
{
    /*
     Orderby to sort a list of digits, first by length of their name, and then alphabetically by the name itself.

        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
     */
    class Problem7
    {
        static void Main(string[] args)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Sorted = digits.OrderBy(p => p.Length).ThenBy(q => q);
            foreach (var item in Sorted)
                Console.WriteLine(item);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignments
{
    /*
    Use select clause to produce a sequence of strings representing the text version of a sequence of ints.

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    */
    class Problem5
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9 };

            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            IEnumerable<string> output = strings.Where((x, y) => numbers.Any(c => c == y));

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}

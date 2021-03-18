using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignments
{
    /*
     Write LINQ code to return digits (from the following list) whose length is shorter than their value.

      string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    */
    class Problem4
    {
        static void Main(string[] args)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            IEnumerable<string> output =  digits.Where(s => s.Length < Array.IndexOf(digits, s));

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}

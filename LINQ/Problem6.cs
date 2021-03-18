using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignments
{
    /*
     * Produce a sequence of the uppercase and lowercase versions of each word in the original array.

    string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

    a. Use orderby to sort a list of words alphabetically.

    b. Orderby to sort a list of words by length.

    * Also try both by descending

    string[] words = { "cherry", "apple", "blueberry" };
    */
    class Problem6
    {
        static void Main(string[] args)
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var words1 = words.Select(x => x.ToUpper());
            var words2 = words.Select(x => x.ToLower());
            var words3 = words2.OrderBy(x => x);
            var words4 = words2.OrderBy(x => x.Length);
            foreach (var i in words1)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            foreach (var i in words2)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            foreach (var i in words3)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            foreach (var i in words4)
            {
                Console.Write(i + "\t");
            }

        }
    }
}

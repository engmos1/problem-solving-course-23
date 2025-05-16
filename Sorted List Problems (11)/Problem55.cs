using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem55
    {
        //Problem 55: Find Elements Less Than a Value.
        static IEnumerable<int> ElementsLessThan(SortedSet<int> set, int value)
        {
            return set.GetViewBetween(int.MinValue, value - 1);
        }

        static void Main1()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            int value = 4;
            Console.WriteLine(string.Join(", ", ElementsLessThan(set, value))); // Output: 1, 2, 3
         

        }
    }
}

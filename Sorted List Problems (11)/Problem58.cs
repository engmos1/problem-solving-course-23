using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{
    class Problem58
    {
        //Problem 58: Find All Elements Not in a Range.

        static int[] FindElementsNotInRange(SortedSet<int> set, int lower, int upper)
        {
           
            var range = set.GetViewBetween(lower, upper);
            return set.Except(range).ToArray();
        }
        static void Main1()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            

            Console.WriteLine(string.Join(", ", FindElementsNotInRange(set,2,4))); 


        }
    }
}

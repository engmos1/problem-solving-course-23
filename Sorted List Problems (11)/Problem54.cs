using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem54
    {
        //Problem 54: Remove Elements Greater Than a Value.

        static void Main1()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            var range = sortedSet.GetViewBetween(int.MinValue, 3);

            sortedSet = new SortedSet<int>(range);
            Console.WriteLine(string.Join(", ", sortedSet)); 
        }
    }
}

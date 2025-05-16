using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{
    class Problem59
    {
        //Problem 59: Find Count of Elements Less Than or Equal to a Value.
        static int CountElementsLessOrEqualThan(SortedSet<int> set, int value)
        {
            return set.GetViewBetween(int.MinValue, value).Count;
        }

        static void Main1()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            int value = 3;
            Console.WriteLine(CountElementsLessOrEqualThan(set, value));


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{
    class Problem56
    {
        //Problem 56: Count Elements Greater Than a Value.
        static int CountElementsGreaterThan(SortedSet<int> set, int value)
        {
            return set.GetViewBetween(value+1,int.MaxValue).Count;
        }

        static void Main1()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            int value = 3;
            Console.WriteLine(CountElementsGreaterThan(set, value)); 
         

        }
    }
}

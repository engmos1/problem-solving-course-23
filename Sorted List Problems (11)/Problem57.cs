using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{
    class Problem57
    {
        //Problem 57: Remove All Elements Within a Range.

        static void Main1()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            var range = set.GetViewBetween(2, 4);
            range.Clear();

            Console.WriteLine(string.Join(", ", set)); 


        }
    }
}

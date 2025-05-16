using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem53
    {
        //Problem 53: Union of Two SortedSets.

        static void Main1()
        {
            SortedSet<int> sortedSet1 = new SortedSet<int> { 1, 2, 3 };

            SortedSet<int> sortedSet2 = new SortedSet<int> { 3, 4, 5 };
           sortedSet1.UnionWith(sortedSet2);
            Console.WriteLine("Union of two SortedSets: " + string.Join(", ", sortedSet1)); // Output: 1, 2, 3, 4, 5 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{
    class Problem60
    {
        //Problem 60: Check If Set Contains Multiple Ranges
        static bool ContainsAllRanges(SortedSet<int> set, List<(int, int)> ranges)
        {
            foreach (var (low, high) in ranges)
            {
                var range = set.GetViewBetween(low, high);
                if (range.Count != (high - low + 1))
                    return false;
            }
            return true;
        }

        static void Main1()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            var ranges = new List<(int, int)> { (1, 2), (4, 5) };
            Console.WriteLine(ContainsAllRanges(set, ranges)); 
            
        }
    }
}

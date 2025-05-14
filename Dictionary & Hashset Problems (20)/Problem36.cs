using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem36
    {
        //Problem 36: Track Unique Visitors to a Website.
        public static void Main1()
        {
            HashSet<string> uniqueVisitors = new HashSet<string>();

            // Simulate website visitors
            uniqueVisitors.Add("192.168.1.1");
            uniqueVisitors.Add("192.168.1.2");
            uniqueVisitors.Add("192.168.1.1"); // Duplicate

            Console.WriteLine("Unique Visitors: " + uniqueVisitors.Count);
        }
       
    }
}

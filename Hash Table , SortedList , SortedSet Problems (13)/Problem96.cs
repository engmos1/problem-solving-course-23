using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem96
    {
        //Problem 96: Track Unique Active Users by Login Time.


        static void Main1()
        {

            SortedSet<DateTime> activeUsers = new SortedSet<DateTime>();

            // Simulate user login times
            activeUsers.Add(new DateTime(2024, 11, 19, 10, 0, 0));
            activeUsers.Add(new DateTime(2024, 11, 19, 10, 15, 0));
            activeUsers.Add(new DateTime(2024, 11, 19, 10, 10, 0));

            Console.WriteLine("Active users login times (sorted):");
            foreach (var time in activeUsers)
            {
                Console.WriteLine(time);
            }

        }

    }
}

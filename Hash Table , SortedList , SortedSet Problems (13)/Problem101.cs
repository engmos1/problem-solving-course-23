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

    class Problem101
    {
        //Problem 101: Manage Unique Flight Times.

        static void Main1()
        {
            SortedSet<DateTime> FlightTimes = new SortedSet<DateTime> 
            {
            new DateTime(2024, 11, 19, 8, 0, 0),
            new DateTime(2024, 11, 19, 12, 45, 0),
            new DateTime(2024, 11, 19, 8, 0, 0) // Duplicate, won't be added
            };

            Console.WriteLine("Flight times (sorted):");
            foreach (var time in FlightTimes)
            {
                Console.WriteLine(time.ToShortTimeString());
            }

        }
    }
}

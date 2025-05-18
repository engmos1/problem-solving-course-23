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

    class Problem97
    {
        //Problem 97: Automatically Sort Event Timelines.

        static void Main1()
        {
            SortedSet<DateTime> eventTimeline = new SortedSet<DateTime>
        {
            new DateTime(2024, 12, 25),
            new DateTime(2024, 11, 30),
            new DateTime(2025, 1, 1)
        };


            Console.WriteLine("Upcoming events:");
            foreach (var eventTime in eventTimeline)
            {
                Console.WriteLine(eventTime.ToShortDateString());
            }
        }

    }
}

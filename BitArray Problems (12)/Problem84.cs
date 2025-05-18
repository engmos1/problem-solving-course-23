using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem84
    {
        //Problem 84: Scheduling Tasks.

        static void Main1()
        {
            BitArray WeeklyTasks = new BitArray(7);

            WeeklyTasks.Set(0, true); // Monday
            WeeklyTasks.Set(1, true); // Tuesday
            WeeklyTasks.Set(2, true); // Wednesday
            WeeklyTasks.Set(3, true); // Thursday
            WeeklyTasks.Set(4, true); // Friday
            WeeklyTasks.Set(5, false); // Saturday
            WeeklyTasks.Set(6, false); // Sunday

            // Print the tasks for each day of the week
            Console.WriteLine("Weekly Tasks:");
            for (int i = 0; i < WeeklyTasks.Count; i++)
            {
                Console.WriteLine($"Day {i + 1}: {(WeeklyTasks[i] ? "Task Scheduled" : "No Task")}");
            }
        }

    }
}

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

    class Problem99
    {
        //Problem 99: Manage Meeting Times for a Calendar.

        static void Main1()
        {
            // Create a dictionary to store meeting times
            SortedList<string, List<DateTime>> meetingTimes = new SortedList<string, List<DateTime>>();
            // Add meeting times
            meetingTimes.Add("Team Meeting", new List<DateTime> { new DateTime(2023, 10, 1, 10, 0, 0), new DateTime(2023, 10, 1, 11, 0, 0) });
            meetingTimes.Add("Project Update", new List<DateTime> { new DateTime(2023, 10, 1, 14, 0, 0), new DateTime(2023, 10, 1, 15, 0, 0) });
            meetingTimes.Add("Client Call", new List<DateTime> { new DateTime(2023, 10, 1, 16, 0, 0), new DateTime(2023, 10, 1, 17, 0, 0) });
            // Display the meeting times for each event
            foreach (var meeting in meetingTimes)
            {
                Console.WriteLine($"Meeting: {meeting.Key}");
                foreach (var time in meeting.Value)
                {
                    Console.WriteLine($"- {time.ToString("yyyy-MM-dd HH:mm")}");
                }
            }
        }

    }
}

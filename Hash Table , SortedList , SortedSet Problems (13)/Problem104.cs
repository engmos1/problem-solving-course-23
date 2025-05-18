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

    class Problem104
    {
        //Problem 104: Schedule Tasks Based on Priority.

        class Task : IComparable<Task>
        {
            public int Priority { get; set; }
            public string Description { get; set; }


            public int CompareTo(Task other)
            {
                // Lower priority number indicates higher importance
                int result = this.Priority.CompareTo(other.Priority);
                if (result == 0)
                {
                    // If priorities are equal, compare descriptions to avoid duplicates
                    result = this.Description.CompareTo(other.Description);
                }
                return result;
            }
        }

        static void Main1()
        {
            SortedSet<Task> tasks = new SortedSet<Task>
            {
            new Task { Priority = 2, Description = "Write report" },
            new Task { Priority = 1, Description = "Fix critical bug" },
            new Task { Priority = 3, Description = "Team meeting" }
            };


            // Add a new task with same priority
            tasks.Add(new Task { Priority = 2, Description = "Review PRs" });


            Console.WriteLine("Tasks in priority order:\n");
            foreach (var task in tasks)
            {
                Console.WriteLine($"Priority: {task.Priority}, Task: {task.Description}");
            }

        }
        
    }
}

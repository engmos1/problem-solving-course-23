using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem37
    {
        //Problem 37: Check for Duplicate Entries in Real-Time.
        public static void Main1()
        {
            HashSet<string> dataEntries = new HashSet<string>();

            string[] entries = { "A", "B", "C", "A" }; // A is a duplicate
            foreach (var entry in entries)
            {
                if (!dataEntries.Add(entry))
                {
                    Console.WriteLine($"Duplicate detected: {entry}");
                }
            }
           



        }

    }
}

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

    class Problem102
    {
        //Problem 102: Manage Tags in a Blogging Platform.

        static void Main1()
        {
            SortedSet<string> tags = new SortedSet<string>();

            // Adding tags
            tags.Add("C#");
            tags.Add("Programming");
            tags.Add("Coding");
            tags.Add("Development");
            tags.Add("Software");
            tags.Add("C#"); // Duplicate, won't be added
            tags.Add("Programming"); // Duplicate, won't be added

            // Displaying all tags
            Console.WriteLine("Tags in the blogging platform:");
            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }
        }
    }
}

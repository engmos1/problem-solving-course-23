using System;
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
    class Problem62
    {
        //Problem 62: Dynamic List of Students in a Classroom


        static void Main1()
        {
            ObservableCollection<string> students = new ObservableCollection<string>();

            students.CollectionChanged += (sender, e) =>
            {
                //this event will be fired on any change (add or remove.

                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Student Added: {e.NewItems[0]}");
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Student Removed: {e.OldItems[0]}");

            };

            students.Add("Alice");
            students.Add("Bob");
            students.Remove("Alice");
            // Output:
            // New Student Added: Alice
            // New Student Added: Bob
            // Student Removed: Alice
           
        }
    }
}

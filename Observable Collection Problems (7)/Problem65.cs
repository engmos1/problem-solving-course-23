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
    class Problem65
    {
        //Problem 65: Task Management System.

        static void Main1()
        {
            ObservableCollection<string> Tasks = new ObservableCollection<string>();
            Tasks.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Task Added: {e.NewItems[0]}");
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Task Removed: {e.OldItems[0]}");
                if (e.Action == NotifyCollectionChangedAction.Replace)
                    Console.WriteLine($"Task Replaced: {e.OldItems[0]} with {e.NewItems[0]}");
            };

            Tasks.Add("Task1");
            Tasks.Add("Task2");
            Tasks.Remove("Task2");
            Tasks[0] = "Task3"; // Replacing Task1 with Task3

        }
    }
}

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
    class Problem68
    {
        //Problem 67: Real-Time Notification System.

        static void Main1()
        {
            ObservableCollection<string> notifications = new ObservableCollection<string>();
            notifications.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Notification: {e.NewItems[0]}");
            };

            notifications.Add("Your order is under processing.");
            notifications.Add("Your order has been shipped.");
            notifications.Add("Your order is Delivered.");
        }
    }
}

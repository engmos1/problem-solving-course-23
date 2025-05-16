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
    class Problem66
    {
        //Problem 66: Live Chat Application.

        static void Main1()
        {
            ObservableCollection<string> chatMessages = new ObservableCollection<string>();
            chatMessages.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Message: {e.NewItems[0]}");
            };

            chatMessages.Add("Hello!");
            chatMessages.Add("How are you?");
        }
    }
}

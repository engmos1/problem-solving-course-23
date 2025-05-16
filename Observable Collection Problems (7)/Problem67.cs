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
    class Problem67
    {
        //Problem 67: Dynamic Weather Updates.

        static void Main1()
        {
            ObservableCollection<string> weatherUpdates = new ObservableCollection<string>();
            weatherUpdates.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Weather Update: {e.NewItems[0]}");
            };

            weatherUpdates.Add("New York: Sunny, 25°C");
            weatherUpdates.Add("London: Rainy, 15°C");
        }
    }
}

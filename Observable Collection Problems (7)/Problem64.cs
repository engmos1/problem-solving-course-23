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
    class Problem64
    {
        //Problem 64: Real-Time Stock Prices.

        static void Main1()
        {
            ObservableCollection<string> stockPrices = new ObservableCollection<string>();
            stockPrices.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Stock Price Added: {e.NewItems[0]}");
            };

            stockPrices.Add("AAPL: 150.00");
            stockPrices.Add("MSFT: 240.50");
        }
    }
}

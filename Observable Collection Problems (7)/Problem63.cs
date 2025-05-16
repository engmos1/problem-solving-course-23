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
    class Problem63
    {
        //Problem 63: Shopping Cart for an E-commerce App.

        static void Main1()
        {
            ObservableCollection<string> ShoppingCart = new ObservableCollection<string>();

            ShoppingCart.CollectionChanged += (sender, e) =>
            {
               

                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Product Added: {e.NewItems[0]}");
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Product Removed: {e.OldItems[0]}");
                if (e.Action == NotifyCollectionChangedAction.Replace)
                    Console.WriteLine($"Product Replaced: {e.OldItems[0]} with {e.NewItems[0]}");
            };

            ShoppingCart.Add("Laptop");
            ShoppingCart.Add("Mouse");
            ShoppingCart.Remove("Mouse");
            ShoppingCart[0] = "Keybourd"; // Replacing Bob with Charlie

        }
    }
}

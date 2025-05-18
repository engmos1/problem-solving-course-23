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

    class Problem100
    {
        //Problem 100: Track Unique Items in a Shopping Cart.

        static void Main1()
        {
           SortedSet <string> ShoppingCart = new SortedSet <string>  
           {
            "Apple",
            "Banana",
            "Orange",
            "Apple" 
           };

            Console.WriteLine("Shopping cart items (sorted):");
            foreach (var item in ShoppingCart)
            {
                Console.WriteLine(item);
            }

        }

    }
}

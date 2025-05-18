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

    class Problem80
    {
        //Problem 80: Simplified Address Representation.

        static void Main1()
        {
            // Test the function
            var address = ("123 Main St", "Springfield", "IL", "62704");
            Console.WriteLine($"Address: {address.Item1}, {address.Item2}, {address.Item3} {address.Item4}");
            var address2 = ("456 Elm St", "Shelbyville", "IL", "62565");
            Console.WriteLine($"Address: {address2.Item1}, {address2.Item2}, {address2.Item3} {address2.Item4}");

        }
    }
}

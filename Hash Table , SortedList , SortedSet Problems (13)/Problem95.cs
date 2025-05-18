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

    class Problem95
    {
        //Problem 95: Find Missing Numbers in a Range.


        static void Main1()
        {
            SortedSet<int> numbers = new SortedSet<int> { 1, 2, 4, 5, 7 };
            Console.Write("Missing number: ");
            for (int i = 1; i <= 7; i++)
            {
                if (!numbers.Contains(i))
                {
                    Console.Write($"{i}, ");
                }
            }


        }

    }
}

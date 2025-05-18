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

    class Problem94
    {
        //Problem 94: Sort and Remove Duplicates from a List.


        static void Main1()
        {
            // Create a list with some duplicate values
            List<int> numbers = new List<int> { 5, 3, 8, 1, 2, 5, 3, 7 };

            
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }


            // Remove duplicates by converting to a HashSet and back to a list
            SortedSet <int> uniqueNumbers = new SortedSet<int>(numbers);
            // Print the sorted list without duplicates
            Console.WriteLine("\nSorted list without duplicates:");
            foreach (int number in uniqueNumbers)
            {
                Console.Write(number + " ");
            }

        }

    }
}

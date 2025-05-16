using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem52
    {
        //Problem 52: Find Smallest and Largest Element.

        static void Main1()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 4, 2, 5, 1, 3 };
           

            Console.WriteLine("Min = "+ sortedSet.Min); 

            Console.WriteLine("Max = " + sortedSet.Max); 
        }
    }
}

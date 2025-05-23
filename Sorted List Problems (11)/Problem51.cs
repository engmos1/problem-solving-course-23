﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem51
    {
        //Problem 51: Find Elements in a Range.

        static void Main1()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            var range = sortedSet.GetViewBetween(2, 4);

            Console.WriteLine(string.Join(", ", range)); // Output: 2, 3, 4
           

        }
    }
}

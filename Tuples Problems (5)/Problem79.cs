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

    class Problem79
    {
        //Problem 79: Return Success or Failure from a Function.

        static (string, double) StudentMark(double Mark)
        {
            if (Mark >= 50)
            {
                return ("Success", Mark);
            }
            else
            {
                return ("Failure", Mark);
            }
        }


        static void Main1()
        {
            // Test the function
            var result = StudentMark(75);
            Console.WriteLine($"Status: {result.Item1}, Mark: {result.Item2}");
            result = StudentMark(45);
            Console.WriteLine($"Status: {result.Item1}, Mark: {result.Item2}");
        }
    }
}

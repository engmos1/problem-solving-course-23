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
    class Problem74
    {
        //Problem 74: Survey Responses.

        static void Main1()
        {
            string[][] responses = new string[3][];
            responses[0] = new string[3] { "Yes", "No", "Maybe" };
            responses[1] = new string[3] { "No", "Yes", "Maybe" };
            responses[2] = new string[3] { "Maybe", "Yes", "No" };
            for (int i = 0; i < responses.Length; i++)
            {
                Console.Write("Survey " + (i + 1) + ": ");
                for (int j = 0; j < responses[i].Length; j++)
                {
                    Console.Write(responses[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}

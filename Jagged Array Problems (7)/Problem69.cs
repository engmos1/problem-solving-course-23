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
    class Problem69
    {
        //Problem 69: Store Marks of Students in Multiple Subjects.

        static void Main1()
        {
           int[][] marks = new int[3][];
            marks[0] = new int[] { 90, 85, 88 };
            marks[1] = new int[] { 76, 80 };
            marks[2] = new int[] { 92, 93, 89, 85 };
            Console.WriteLine("Marks of Students in Multiple Subjects:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Student " + (i + 1) + ": ");
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.Write(marks[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

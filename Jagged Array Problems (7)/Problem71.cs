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
    class Problem71
    {
        //Problem 71: Dynamic Seating Arrangement in a Classroom.

        static void Main1()
        {
           int[][] seatingArrangement = new int[3][];
            seatingArrangement[0] = new int[] { 1, 2, 3 };
            seatingArrangement[1] = new int[] { 4, 5 };
            seatingArrangement[2] = new int[] { 6, 7, 8, 9 };
            seatingArrangement[3] = new int[] { 10, 11, 12, 13, 14 };
            for (int i = 0; i < seatingArrangement.Length; i++)
            {
                Console.Write("Row " + (i + 1) + ": ");
                for (int j = 0; j < seatingArrangement[i].Length; j++)
                {
                    Console.Write(seatingArrangement[i][j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}

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
    class Problem72
    {
        //Problem 72: Daily Sales for Different Products.

        static void Main1()
        {
            int[][] Products = new int[3][];

            Products[0] = new int[] { 100, 200, 300 };
            Products[1] = new int[] { 400, 500 };
            Products[2] = new int[] { 700, 800, 900,1000 };
            //Products[3] = new int[] { 1000, 1100, 1200 };

            for (int i = 0; i < Products.Length; i++)
            {
                Console.Write("Product " + (i + 1) + ": ");
                for (int j = 0; j < Products[i].Length; j++)
                {
                    Console.Write(Products[i][j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}

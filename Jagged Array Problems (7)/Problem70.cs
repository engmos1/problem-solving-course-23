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
    class Problem70
    {
        //Problem 70: Store sales data for a company across different regions for various quarters.

        static void Main1()
        {
           int[][] salesdata = new int[3][];
            salesdata[0] = new int[] { 10000, 12000, 11000 };
            salesdata[1] = new int[] { 15000, 16000 };
            salesdata[2] = new int[] { 9000, 9500, 9800, 10200 };
           
            for (int i = 0; i < salesdata.Length; i++)
            {
                Console.Write("Region " + (i + 1) + ": ");
                for (int j = 0; j < salesdata[i].Length; j++)
                {
                    Console.Write(salesdata[i][j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}

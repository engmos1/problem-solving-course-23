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
    class Problem75
    {
        //Problem 75: City Temperature Data.

        static void Main1()
        {
            int[][] temperatures = new int[3][];
            temperatures[0] = new int[3] { 30, 32, 35 };
            temperatures[1] = new int[3] { 28, 29, 31 };
            temperatures[2] = new int[3] { 25, 27, 26 };
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.Write("City " + (i + 1) + ": ");
                for (int j = 0; j < temperatures[i].Length; j++)
                {
                    Console.Write(temperatures[i][j] + "°C  ");
                }
                Console.WriteLine();
            }
        }
    }
}

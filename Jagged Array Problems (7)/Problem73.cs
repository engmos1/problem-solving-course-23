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
    class Problem73
    {
        //Problem 73: Flight Seat Reservations.

        static void Main1()
        {
            bool[][] Seats = new bool[3][];
            Seats[0] = new bool[3] { true, false, false };
            Seats[1] = new bool[3] { true, false,true };
            Seats[2] = new bool[3] { false, true, true };
            for (int i = 0; i < Seats.Length; i++)
            {
                Console.Write("Flight " + (i + 1) + ": ");
                for (int j = 0; j < Seats[i].Length; j++)
                {
                    Console.Write(Seats[i][j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}

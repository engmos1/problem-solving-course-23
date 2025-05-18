using System;
using System.Collections;
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

    class Problem83
    {
        //Problem 83: Optimizing Space in Large Data.

        static void Main1()
        {
            BitArray seats = new BitArray(1000); // 1 million bits
            // Set some bits to true
            seats[0] = true;
            seats[500] = true;
            seats[999] = true;
            // Display the occupied seats
            Console.WriteLine("Occupied Seats:");
            for (int i = 0; i < seats.Count; i++)
            {
                if (seats[i])
                {
                    Console.WriteLine($"Seat {i + 1} is occupied.");
                }
            }

        }

    }
}

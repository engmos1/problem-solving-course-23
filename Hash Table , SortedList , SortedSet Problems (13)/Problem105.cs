using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem105
    {
        //Problem 105: Manage Reserved Seats in a Theater.


        static void Main()
        {
            SortedSet<int> reservedSeats = new SortedSet<int> { 10, 20, 30 };


            reservedSeats.Add(25);


            if (!reservedSeats.Add(10))
            {
                // Duplicate, won't be added
                Console.WriteLine("\nSeat 10 is already reserved!\n");
            }
            ;


            Console.WriteLine("Reserved Seats:");
            foreach (var seat in reservedSeats)
            {
                Console.WriteLine("Seat " + seat);
            }

        }
        
    }
}

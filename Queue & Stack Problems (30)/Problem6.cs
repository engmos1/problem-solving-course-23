using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem6
    {
        // Problem 6: Ticketing System Simulation.
        static void Main1()
        {
            
            Queue<int> ticketQueue = new Queue<int>();

           
            for (int i = 101; i <= 105; i++)
            {
                ticketQueue.Enqueue(i);
                Console.WriteLine($"Ticket {i} issued.");
            }

            Console.WriteLine("\nTicketing System Simulation Started...\n");

            
            while (ticketQueue.Count > 0)
            {
                int currentTicket = ticketQueue.Dequeue();
                Console.WriteLine($"Processing Ticket: {currentTicket}");


                
                if (ticketQueue.Count > 0)
                {
                    Console.WriteLine("Remaining Tickets: " + string.Join(", ", ticketQueue));
                }
                else
                {
                    Console.WriteLine("No more tickets in the queue.");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ticketing System Simulation Ended.");

        }
    }
}

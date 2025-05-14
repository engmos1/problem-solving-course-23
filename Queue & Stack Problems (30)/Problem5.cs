using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem5
    {
        // Problem 5: Traffic Signal System Simulation.
        static void Main1()
        {
            Queue<string> trafficQueue = new Queue<string>();
            // Adding vehicles to the queue
            trafficQueue.Enqueue("Car1");
            trafficQueue.Enqueue("Truk1");
            trafficQueue.Enqueue("Bus1");
            trafficQueue.Enqueue("Bike1");

            while (trafficQueue.Count > 0)
            {
                Console.WriteLine("Traffic Signal Simulation Started...");
                string prossessingVehicle = trafficQueue.Dequeue();
                Console.WriteLine($"{prossessingVehicle} has passed the signal.");
                if (trafficQueue.Count > 0)
                {
                    Console.WriteLine("Vehicles waiting:" + string.Join(" ", trafficQueue));
                }
                else
                {
                    Console.WriteLine("Traffic Signal Simulation Ended.");
                }

            }

        }
    }
}

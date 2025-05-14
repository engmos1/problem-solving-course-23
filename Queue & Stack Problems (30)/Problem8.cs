using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem8
    {
        // Problem 8: Task Scheduling.
        static void Main1()
        {
            
            Queue<string> TaskScheduling = new Queue<string>();

            // Adding tasks to the queue
            TaskScheduling.Enqueue("Task 1");
            TaskScheduling.Enqueue("Task 2");
            TaskScheduling.Enqueue("Task 3");
            TaskScheduling.Enqueue("Task 4");
            TaskScheduling.Enqueue("Task 5");
            TaskScheduling.Enqueue("Task 6");

            Console.WriteLine("\nTasks Processing...\n");

            
            while (TaskScheduling.Count > 0)
            {
                string currentTicket = TaskScheduling.Dequeue();
                Console.WriteLine($"Processing : {currentTicket}");


               
                Console.WriteLine();
            }

            

        }
    }
}

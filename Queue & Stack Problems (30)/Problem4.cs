using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem4
    {
        // Problem 4: Printer Job Scheduling useing Queue.
        static void Main1()
        {
            Queue<string> PrinterJob = new Queue<string>();

            // Adding jobs to the queue
            PrinterJob.Enqueue("Doc1");
            PrinterJob.Enqueue("Doc2");
            PrinterJob.Enqueue("Doc3");

            Console.WriteLine("printer jobs in the queue:");
            foreach (var job in PrinterJob)
            {
                Console.WriteLine(job);
            }
            // Processing the jobs
            while (PrinterJob.Count > 0)
            {
                string currentJob = PrinterJob.Dequeue();
                Console.WriteLine($"Processing {currentJob}...");
                // Simulate processing time
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"{currentJob} processed.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem10
    {
        // Problem 10: Web Page Request Handling.
        static void Main1()
        {

            Queue<string> requests = new Queue<string>();
            requests.Enqueue("Request1");
            requests.Enqueue("Request2");
            requests.Enqueue("Request3");


            Console.WriteLine("Processing web requests:\n");
            while (requests.Count > 0)
            {
                string currentRequest = requests.Dequeue();
                Console.WriteLine($"Processed: {currentRequest}");
            }
        }
    }
}

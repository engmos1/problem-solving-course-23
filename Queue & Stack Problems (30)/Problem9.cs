using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem9
    {
        // Problem 9: Customer Service.
        static void Main1()
        {
            
            Queue<string> CustomerService = new Queue<string>();


            // Adding customers to the queue
            CustomerService.Enqueue("Customer 1");
            CustomerService.Enqueue("Customer 2");
            CustomerService.Enqueue("Customer 3");
            CustomerService.Enqueue("Customer 4");
            CustomerService.Enqueue("Customer 5");


            Console.WriteLine("\nServing customers...\n");

            
            while (CustomerService.Count > 0)
            {
                string currentTicket = CustomerService.Dequeue();
                Console.WriteLine($"Serving : {currentTicket}");

                Console.WriteLine();
            }
        }
    }
}

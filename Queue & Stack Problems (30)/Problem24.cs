using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem24
    {
        // Problem 24: Find Middle Element in a Queue.
        static int? MiddleElement(Queue<int> queue)
        {
            if (queue.Count == 0) return null;

            List<int> list = new List<int>(queue);
            int middle = 0;
            if (list.Count%2!=0)
             middle = list[(list.Count/2)];
            else
                middle = list[(list.Count / 2)-1];

            return middle;
        }

        static void Main1()
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
           
            Console.WriteLine(string.Join(", ", queue)); // Output: 1, 2, 3, 4
            int? mid= MiddleElement(queue);
            Console.WriteLine($"{mid}");
        }
    }
}

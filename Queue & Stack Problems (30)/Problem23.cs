using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem23
    {
        // Problem 23: Clone a Queue Without Using Extra Space.
        static Queue<int> CloneQueue(Queue<int> queue)
        {
            if (queue.Count == 0) return null;

            Queue<int> colon = new Queue<int>();

            colon = queue;

            return colon;
        }

        static void Main1()
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4 });
            Queue<int> clonedQueue = CloneQueue(queue);
            Console.WriteLine(string.Join(", ", clonedQueue)); // Output: 1, 2, 3, 4
            Console.WriteLine(string.Join(", ", queue)); // Output: 1, 2, 3, 4
        }
    }
}

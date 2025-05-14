using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem16
    {
        // Problem 16: Rotate a Queue.

        static Queue<int> RotateQueue(Queue<int> queue, int k)
        {
            for (int i = 0; i < k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            return queue;
        }


        static void Main1()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            Console.WriteLine("Original Queue: " + string.Join(", ", queue));
            queue = RotateQueue(queue, 3);
            Console.WriteLine("Rotate a Queue: " + string.Join(", ", queue));


        }
    }
}

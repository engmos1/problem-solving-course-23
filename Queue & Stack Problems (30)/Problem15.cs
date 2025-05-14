using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem15
    {
        // Problem 15: Interleave Queue Elements.

        public static void InterleaveQueue(Queue<int> queue)
        {
            if (queue.Count % 2 != 0)
            {
                throw new ArgumentException("Queue must have an even number of elements.");
            }
            int halfSize = queue.Count / 2;
            Stack<int> stack = new Stack<int>();
            // Dequeue the first half and push it onto the stack
            for (int i = 0; i < halfSize; i++)
            {
                stack.Push(queue.Dequeue());
            }
            // Enqueue the elements from the stack back to the queue
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            // Dequeue the second half and enqueue it back to the queue
            for (int i = 0; i < halfSize; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            // Again, push the first half onto the stack
            for (int i = 0; i < halfSize; i++)
            {
                stack.Push(queue.Dequeue());
            }
            // Interleave the elements from the stack and the queue
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
                queue.Enqueue(queue.Dequeue());
            }
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
            InterleaveQueue(queue);
            Console.WriteLine("Interleaved Queue: " + string.Join(", ", queue));


        }
    }
}

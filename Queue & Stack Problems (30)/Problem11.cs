using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem11
    {
        // Problem 11: Reverse a Queue.

        public static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            // Dequeue all elements from the queue and push them onto the stack
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            // Pop all elements from the stack and enqueue them back to the queue
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
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
            Console.WriteLine("Original Queue: " + string.Join(", ", queue));
            ReverseQueue(queue);
            Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));

        }
    }
}

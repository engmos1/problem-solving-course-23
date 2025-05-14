using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem19
    {
        // Problem 19: Queue Using Two Stacks.

        public class MyQueue <T>
        {
            private Stack<T> stack1;
            private Stack<T> stack2;
            public MyQueue()
            {
                stack1 = new Stack<T>();
                stack2 = new Stack<T>();
            }
            public void enqeueu(T x)
            {
                stack1.Push(x);
            }
            public T dequeue()
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }
                return stack2.Pop();
            }
            public T Peek()
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }
                return stack2.Peek();
            }
            public bool Empty()
            {
                return stack1.Count == 0 && stack2.Count == 0;
            }
        }

        static void Main1()
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.enqeueu(1);
            queue.enqeueu(2);
            Console.WriteLine(queue.Peek()); // Output: 1
            Console.WriteLine(queue.dequeue());  // Output: 1
            Console.WriteLine(queue.Empty()); // Output: False
        }
    }
}

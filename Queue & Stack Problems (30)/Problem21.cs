using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem21
    {
        // Problem 21: Implement a Priority Queue.
        class PriorityQueue
        {
            private SortedDictionary<int, Queue<int>> queue = new SortedDictionary<int, Queue<int>>();


            public void Enqueue(int value, int priority)
            {
                if (!queue.ContainsKey(priority))
                {
                    queue[priority] = new Queue<int>();
                }
                queue[priority].Enqueue(value);
            }


            public int? Dequeue()
            {
                if (queue.Count == 0) return null;


                int highestPriority = queue.Keys.Min();
                int value = queue[highestPriority].Dequeue();
                if (queue[highestPriority].Count == 0)
                {
                    queue.Remove(highestPriority);
                }
                return value;
            }
        }
        static void Main1()
        {
            PriorityQueue pq = new PriorityQueue();
            pq.Enqueue(10, 3);
            pq.Enqueue(5, 1);
            pq.Enqueue(6, 1);
            pq.Enqueue(7, 1);
            pq.Enqueue(20, 2);
            Console.WriteLine(pq.Dequeue()); // Output: 5
            Console.WriteLine(pq.Dequeue());
            Console.WriteLine(pq.Dequeue());
            
        }
    }
}

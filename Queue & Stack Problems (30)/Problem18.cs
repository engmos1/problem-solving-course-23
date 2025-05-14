using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem18
    {
        // Problem 18: First Non-Repeating Character in a Stream.

        static void FindFirstNonRepeating(string stream)
        {
            Dictionary<char, int> countMap = new Dictionary<char, int>();
            Queue<char> queue = new Queue<char>();


            foreach (char ch in stream)
            {
                if (!countMap.ContainsKey(ch))
                    countMap[ch] = 0;


                countMap[ch]++;
                queue.Enqueue(ch);


                while (queue.Count > 0 && countMap[queue.Peek()] > 1)
                {
                    queue.Dequeue();
                }


                Console.WriteLine(queue.Count > 0 ? queue.Dequeue() : '-');
            }
        }

        static void Main1()
        {
            FindFirstNonRepeating("aabc");
            // Output: a, -, b, c
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem20
    {
        // Problem 20: Rearrange Queue Alternately.
        static Queue<int> RearrangeQueueAlternately(Queue<int> queue)
        {   
            List<int> list = new List<int>(queue);
            int n = list.Count;
            Queue<int> result = new Queue<int>();

            for (int i = 0; i < n / 2; i++)
            {
                result.Enqueue(list[i]);
                result.Enqueue(list[n - i - 1]);
            }

            if (n % 2 != 0)
            {
                result.Enqueue(list[n / 2]);
            }

            return result;
        }
        static void Main1()
        {

            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
            Queue<int> rearrangedQueue = RearrangeQueueAlternately(queue);
            Console.WriteLine(string.Join(", ", rearrangedQueue)); // Output: 1, 6, 2, 5, 3, 4
           
        }
    }
}

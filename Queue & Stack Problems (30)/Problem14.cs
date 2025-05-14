using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem14
    {
        // Problem 14: Sort a Queue.
        static Queue<int> SortAQueue(Queue<int> queue)
        {
            List<int> list = new List<int>(queue);

            list.Sort();

            return new Queue<int>(list);

        }
        static void Main1()
        {

            int[] ints = { 5, 1, 3, 2, 4 };
            Queue<int> queue = new Queue<int>(ints);

            queue = SortAQueue(queue);

            Console.WriteLine(string.Join(", ", queue));
           
        }
    }
}

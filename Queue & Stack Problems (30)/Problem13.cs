using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem13
    {
        // Problem 13: Generate Binary Numbers.

        public static void GenerateBinaryNumbers(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            for (int i = 0; i < n; i++)
            {
                string binaryNumber = queue.Dequeue();
                Console.WriteLine(binaryNumber);
                queue.Enqueue(binaryNumber + "0");
                queue.Enqueue(binaryNumber + "1");
            }
        }
        static void Main1()
        {

            Console.WriteLine("Enter the number of binary numbers to generate:");
            int n = Convert.ToInt32(Console.ReadLine());
            GenerateBinaryNumbers(n);

        }
    }
}

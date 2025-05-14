using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem12
    {
        // Problem 12: Palindrome Queue.

        public static bool Palindrome(Queue<int> queue)
        {
            // Check if the queue is empty
            if (queue.Count == 0)          
                return false;
            
            // Create a stack to reverse the order of elements
            Stack<int> stack = new Stack<int>(queue);
            // Compare the elements in the queue and stack
            while (queue.Count > 0)
            {
                int front = queue.Dequeue();
                int back = stack.Pop();
                if (front != back)
                {
                   
                    return false;
                }
            }
            return true;
        }
        static void Main1()
        {

            // Example usage
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            bool isPalindrome = Palindrome(queue);
            Console.WriteLine("Is the queue a palindrome? " + isPalindrome);
            
            Queue<int> Queue1 = new Queue<int>();
            Queue1.Enqueue(1);
            Queue1.Enqueue(1);
            Queue1.Enqueue(3);
            Queue1.Enqueue(2);
            Queue1.Enqueue(3);

            bool isEmptyPalindrome = Palindrome(Queue1);
            Console.WriteLine("Is the empty queue a palindrome? " + isEmptyPalindrome);


        }
    }
}

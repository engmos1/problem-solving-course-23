using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem27
    {
        // Problem 27: Check palindrome using a stack .
        static bool Ispalindrome(string input)
        {
            Stack<char> stack = new Stack<char>();


            foreach (char c in input)
            {
                    stack.Push(c); 
            }
            foreach (char c in input)
            {
                char s = stack.Pop();
                if (c!=s)
                    return false;
            }

            return true; // Stack should be empty if balanced
        }


        static void Main1()
        {
            string input = "madam";
            Console.WriteLine($"Is \"{input}\" a palindrome? {Ispalindrome(input)}");


            input = "hello";
            Console.WriteLine($"Is \"{input}\" a palindrome? {Ispalindrome(input)}");

        }
    }
}

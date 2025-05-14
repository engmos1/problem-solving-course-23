using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem25
    {
        // Problem 25: Reverse a String.
        static string Reverse(string input)
        {
            Stack<char> stack = new Stack<char>();

            // Push each character onto the stack
            foreach (char c in input)
            {
                stack.Push(c);
            }

            // Pop characters to form the reversed string
            string reversed = "";
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            return reversed;
        }


        static void Main1()
        {
            string input = "hello";
            Console.WriteLine($"Original: {input}");
            Console.WriteLine($"Reversed: {Reverse(input)}");
        }
    }
}

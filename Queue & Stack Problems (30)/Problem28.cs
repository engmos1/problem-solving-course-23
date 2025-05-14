using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem28
    {
        // Problem 28: Evaluate a Postfix Expression.
        static int EvaluatePostfix(string input)
        {
            Stack<int> stack = new Stack<int>();


            foreach (char c in input)
            {
                if (char.IsDigit(c))
                { stack.Push(c - '0'); }
                else
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    switch (c)
                    {
                        case '+': stack.Push(a + b); break;
                        case '-': stack.Push(a - b); break;
                        case '*': stack.Push(a * b); break;
                        case '/': stack.Push(a / b); break;
                    }

                }
            }
           

            return stack.Pop(); // Stack should be empty if balanced
        }


        static void Main1()
        {
            Console.WriteLine(EvaluatePostfix("231*+9-")); // Output: -4
           

        }
    }
}

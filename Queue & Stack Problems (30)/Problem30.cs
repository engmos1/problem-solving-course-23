using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem30
    {
        // Problem 30: Remove Invalid Parentheses.
        static string RemoveInvalidParentheses(string s)
        {
            Stack<int> stack = new Stack<int>();
            HashSet<int> invalidIndices = new HashSet<int>();


            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else if (s[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        invalidIndices.Add(i);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }


            while (stack.Count > 0)
            {
                invalidIndices.Add(stack.Pop());
            }


            char[] result = new char[s.Length - invalidIndices.Count];
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!invalidIndices.Contains(i))
                {
                    result[index++] = s[i];
                }
            }

            return new string(result);
        }

        private static string RemoveInvalidParentheses1(string expression)
        {
            var stack = new Stack<Tuple<char, int>>();

            var validStr = "";

            for (var i = 0; i < expression.Length; i++)
            {
                if (expression[i] is '(')
                {
                    stack.Push(Tuple.Create(expression[i], i));

                    validStr += expression[i];
                }

                else
                {
                    if (stack.Count == 0) continue;

                    stack.Pop();

                    validStr += expression[i];
                }
            }

            foreach (var c in stack)
            {
                validStr = validStr.Remove(c.Item2, 1);
            }

            return validStr;
        }
        static void Main1()
        {
            Console.WriteLine(RemoveInvalidParentheses("(((((()))")); // Output: "(())" or "()"
            Console.WriteLine(RemoveInvalidParentheses1("(((((()))")); // Output: "(())" or "()"
        }
    }
}

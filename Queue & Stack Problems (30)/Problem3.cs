using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem3
    {
        // Problem 2: Undo Operations in a Calculator.
        static void Main1()
        {
            Console.WriteLine("Enter a mathematical expression (e.g., 3+2*2):");
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            int result = 0;
            char operation = '+';
            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]))
                {
                    int num = expression[i] - '0';
                    while (i + 1 < expression.Length && char.IsDigit(expression[i + 1]))
                    {
                        num = num * 10 + (expression[++i] - '0');
                    }
                    if (operation == '+')
                    {
                        stack.Push(num);
                    }
                    else if (operation == '-')
                    {
                        stack.Push(-num);
                    }
                    else if (operation == '*')
                    {
                        stack.Push(stack.Pop() * num);
                    }
                    else if (operation == '/')
                    {
                        stack.Push(stack.Pop() / num);
                    }
                }
                else
                {
                    operation = expression[i];
                }
            }
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }
            Console.WriteLine("Result: " + result);

        }
    }
}

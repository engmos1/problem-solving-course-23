﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem29
    {
        // Problem 29: Basic Calculator.
        static int Calculate(string s)
        {
            Stack<int> stack = new Stack<int>();
            int result = 0, sign = 1, number = 0;


            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    number = number * 10 + (c - '0');
                }
                else if (c == '+')
                {
                    result += sign * number;
                    number = 0;
                    sign = 1;
                }
                else if (c == '-')
                {
                    result += sign * number;
                    number = 0;
                    sign = -1;
                }
                else if (c == '(')
                {
                    stack.Push(result);
                    stack.Push(sign);
                    result = 0;
                    sign = 1;
                }
                else if (c == ')')
                {
                    result += sign * number;
                    number = 0;
                    result *= stack.Pop();
                    result += stack.Pop();
                }
            }

            result += sign * number;
            return result;
        }



        static void Main1()
        {
            Console.WriteLine(Calculate("1 + (5 - 3)")); // Output: 3


        }
    }
}





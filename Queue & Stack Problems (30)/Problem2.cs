using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem2
    {
        // Problem 2: Convert Decimal to Binary using Stack.
        static void Main2()
        {
            Console.WriteLine("Enter a decimal number:");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            Stack<int> binaryStack = new Stack<int>();
            // Convert decimal to binary
            while (decimalNumber > 0)
            {
                binaryStack.Push(decimalNumber % 2);
                decimalNumber /= 2;
            }
            // Print binary representation
            Console.Write("Binary representation: ");
            while (binaryStack.Count > 0)
            {
                Console.Write(binaryStack.Pop());
            }

        }
    }
}

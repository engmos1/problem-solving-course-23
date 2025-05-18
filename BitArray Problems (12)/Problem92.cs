using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem92
    {
        //Problem 92:  Create a BitArray from an Integer.

        static BitArray IntToBitArray(int number)
        {
            return new BitArray(new[] { number });
        }


        static void Main1()
        {
            int number = 10; // Binary: 1010
            BitArray bits = IntToBitArray(number);


            Console.Write("BitArray representation of " + number + ": ");
            bool leadingZero = true; // To suppress leading zeros
            for (int i = bits.Length - 1; i >= 0; i--)
            {
                if (bits[i])
                {
                    leadingZero = false;
                }
                if (!leadingZero)
                {
                    Console.Write(bits[i] ? "1" : "0");
                }
            }


            // In case the number is 0, print a single "0"
            if (leadingZero)
            {
                Console.Write("0");
            }

        }

    }
}

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

    class Problem91
    {
        //Problem 91:  Convert a BitArray to an Integer.

        static int BitArrayToInt(BitArray bitArray)
        {
            int result = 0;
            for (int i = 0; i < bitArray.Count; i++)
            {
                if (bitArray[i])
                {
                    result += (int)Math.Pow(2, i);
                }
            }
            return result;
        }

        static void Main1()
        {
            BitArray bits = new BitArray(new bool[] { true, false, true }); // Binary: 101
            int number = BitArrayToInt(bits);
            Console.WriteLine("Integer value of BitArray: " + number);

        }

    }
}

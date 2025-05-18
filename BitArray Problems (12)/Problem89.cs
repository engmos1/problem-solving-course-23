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

    class Problem89
    {
        //Problem 89: Count the Number of True Bits / False Bits in a BitArray.

        static int NumberofTrueBits(BitArray bitArray)
        {
            int count = 0;
            for (int i = 0; i < bitArray.Count; i++)
            {
                if (bitArray[i] == true)
                    count++;
            }
            return count;
        }

        static int NumberofFalesBits(BitArray bits)
        {
            int count = 0;
            foreach (bool bit in bits)
            {
                if (!bit) count++;
            }
            return count;
        }
        static void Main1()
        {
            BitArray bitArray = new BitArray(8);

             
            bitArray[0] = true;
            bitArray[3] = true;
            bitArray[6] = true;
            bitArray[7] = true;

            int Count = NumberofTrueBits(bitArray);

            Console.WriteLine("Number of True Bits = " +  Count);

            int CountFalse = NumberofFalesBits(bitArray);

            Console.WriteLine("Number of False Bits = " + CountFalse);

        }

    }
}

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

    class Problem90
    {
        //Problem 90: Perform Bitwise AND Between Two BitArrays.

        
        static void Main1()
        {
            BitArray bitArray = new BitArray(8);

             
            bitArray[0] = true;
            bitArray[3] = true;
            bitArray[6] = true;
            bitArray[7] = true;

          BitArray bitArray2 = new BitArray(8);
            bitArray2[1] = true;
            bitArray2[3] = true;
            bitArray2[4] = true;
            bitArray2[5] = true;

            // Perform bitwise AND operation
            BitArray result = new BitArray(bitArray);
            result.And(bitArray2);
            // Print the result
            Console.WriteLine("Result of Bitwise AND:");
            for (int i = 0; i < result.Count; i++)
            {   
                Console.Write(result[i] ? "1" : "0");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem42
    {
        //Problem 42:Find Duplicate Elements.
        static int[] DuplicateElements(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
           List<int> Duplicate = new List<int>() ;
            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                    if (counts[num] == 2) // Add to duplicates only once
                        Duplicate.Add(num);
                }
                else
                {
                    counts[num] = 1;
                }
            }


            return Duplicate.ToArray();
        }

        static void Main1()
        {
            int[] ints = { 1, 2, 3, 4, 2, 5, 6, 1 };
            var result = DuplicateElements(ints);
            Console.Write("Duplicate elements are: ");

            Console.Write( string.Join(", ", result)); 
        }
    }
}

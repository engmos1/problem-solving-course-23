using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem43
    {
        //Problem 43:Find All Unique Elements.
        static int[] UniqueElements(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
           List<int> unique = new List<int>() ;
            foreach (int num in nums)
            {
                if (!counts.ContainsKey(num))
                    counts[num] = 0;


                counts[num]++;
            }


            foreach (var kvp in counts)
            {
                if (kvp.Value == 1)
                    unique.Add(kvp.Key);
            }


            return unique.ToArray();
        }

        static void Main1()
        {
            int[] ints = { 1, 2, 3, 4, 2, 5, 6, 1 };
            var result = UniqueElements(ints);
            Console.Write("Unique elements are: ");

            Console.Write( string.Join(", ", result)); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem41
    {
        //Problem 41: Find Majority Element.
        static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            int majorityCount = nums.Length / 2;
            foreach (int num in nums)
            {
                if (!counts.ContainsKey(num))
                    counts[num] = 0;

                counts[num]++;

                if (counts[num] > majorityCount)
                    return num;
            }
            
            return -1;
        }

        static void Main1()
        {
            int[] ints = { 3, 2, 3 };
            var result = MajorityElement(ints);
            Console.WriteLine(result); // Output: 3
        }
    }
}

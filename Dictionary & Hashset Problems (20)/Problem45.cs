using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem45
    {
        //Problem 45: Find Missing Number in an Array.
        static int FindMissingNumber(int[] nums)
        {

            HashSet<int> set = new HashSet<int>(nums);
            int n = nums.Length;

            for (int i = 0; i <= n; i++)
            {
                if (!set.Contains(i))
                    return i;
            }

            return -1;
        }

        static void Main1()
        {
            int[] nums = { 3, 0, 1, 4, 5, 6 };
            Console.WriteLine(FindMissingNumber(nums)); // Output: 2

        }
    }
}

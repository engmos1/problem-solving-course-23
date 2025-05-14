using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem48
    {
        //Problem 48: Find Numbers Disappeared in an Array.
        static int [] FindNumbersDisappeared(int[] nums)
        {

            HashSet<int> set = new HashSet<int>(nums);
            int n = nums.Length;
            List<int> result = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (!set.Contains(i))
                {
                    result.Add(i);
                }

            }

            return result.ToArray();
        }

        static void Main1()
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.WriteLine(string.Join(", ", FindNumbersDisappeared(nums))); // Output: 5, 6
            

        }
    }
}

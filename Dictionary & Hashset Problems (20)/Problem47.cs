using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem47
    {
        //Problem 47: Find Elements Not in the Second Array.
        static int [] ElementsNotInSecondArray(int[] arr1, int[]arr2)
        {
           HashSet<int> set = new HashSet<int>(arr2);   
           HashSet<int> result = new HashSet<int>(arr1);

           result.ExceptWith(set);

            return result.ToArray();
        }

        static void Main1()
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] nums2 = { 3, 4, 5, 6 };
            Console.WriteLine(string.Join(", ", ElementsNotInSecondArray(nums1, nums2))); // Output: 1, 2
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem49
    {
        //Problem 49: Check if Two Arrays are Disjoint.
      
        public static bool AreDisjoint(int[] nums1, int[] nums2)
        {
            return !nums1.Intersect(nums2).Any();
        }


        static void Main1()
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 4, 5, 6 };
            Console.WriteLine(AreDisjoint(nums1, nums2)); // Output: True
            

        }
    }
}

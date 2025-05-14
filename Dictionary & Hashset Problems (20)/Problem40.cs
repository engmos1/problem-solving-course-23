using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem40
    {
        //Problem 40: Find Longest Consecutive Sequence.

        static int FindLongestConsecutiveSequence(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            int longestStreak = 0;
            foreach (int num in numSet)
            {
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;
                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }
                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }
            return longestStreak;
        }

        static void Main1()
        {
            int[] arr = { 100, 4, 200, 1, 3, 2,5,6 };
            Console.WriteLine(FindLongestConsecutiveSequence(arr));
        }
    }
}

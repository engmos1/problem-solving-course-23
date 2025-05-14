using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem46
    {
        //Problem 46: Find Common Characters in Strings.
        static List<string> CommonChars(string[] words)
        {
            int[] minFreq = new int[26];
            for (int i = 0; i < minFreq.Length; i++)
            {
                minFreq[i] = int.MaxValue;
            }

            foreach (string word in words)
            {
                int[] charFreq = new int[26];
                foreach (char c in word)
                {
                    charFreq[c - 'a']++;
                }


                for (int i = 0; i < 26; i++)
                {
                    minFreq[i] = Math.Min(minFreq[i], charFreq[i]);
                }
            }

            List<string> result = new List<string>();
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < minFreq[i]; j++)
                {
                    result.Add(((char)(i + 'a')).ToString());
                }
            }

            return result;
        }

        static void Main1()
        {
            var result = CommonChars(new[] { "bella", "label", "roller" });
            Console.WriteLine(string.Join(", ", result)); // Output: e, l, l
        }
    }
}

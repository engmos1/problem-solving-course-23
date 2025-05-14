using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem39
    {
        //Problem 39: Find the Frequency of Each Character.
        static Dictionary<char, int> CharacterFrequency(string input)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;
            }

            return frequency;
        }

        static void Main1()
        {
            string input = "hello";
            var result = CharacterFrequency(input);
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem50
    {
        //Problem 50: Check If a Sentence Is Pangram.

        static bool IsPangram(string sentence)
        {
            HashSet<char> letters = new HashSet<char>();


            foreach (char c in sentence.ToLower())
            {
                if (char.IsLetter(c))
                    letters.Add(c);
            }

            return letters.Count == 26;
        }

        static void Main1()
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(IsPangram(sentence)); 
            
        }
    }
}

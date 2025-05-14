using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem34
    {
        //Problem 34: Count Word Frequencies in a Text.
        public static void Main1()
        {
            string text = "Hello world! Hello everyone. Welcome to the world of programming.";
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string[] words = text.Split(new char[] { ' ', '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                if (wordCount.ContainsKey(lowerWord))
                {
                    wordCount[lowerWord]++;
                }
                else
                {
                    wordCount[lowerWord] = 1;
                }
            }
            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
       
    }
}

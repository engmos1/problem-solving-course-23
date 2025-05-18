using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem103
    {
        //Problem 103: Autocomplete Suggestions in a Search Feature.

        static void Main1()
        {
            SortedSet<string> words = new SortedSet<string>
        {
            "apple", "application", "appreciate", "banana", "band", "bandwidth", "cat", "cater"
        };

            Console.Write("Enter a prefix: ");
            string prefix = Console.ReadLine();

            var suggestions = GetSuggestions(words, prefix);

            Console.WriteLine("Suggestions:");
            foreach (var word in suggestions)
            {
                Console.WriteLine(word);
            }
        }
        static List<string> GetSuggestions(SortedSet<string> words, string prefix)
        {
            List<string> suggestions = new List<string>();
            foreach (var word in words)
            {
                if (word.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    suggestions.Add(word);
                }
            }
            return suggestions;
        }
    }
}

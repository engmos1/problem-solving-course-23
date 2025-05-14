using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem35
    {
        //Problem 35: Phonebook Application.
        public static void Main1()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>
        {
            { "Alice", "123-456-7890" },
            { "Bob", "987-654-3210" }
        };
            // Adding a new entry
            phonebook["Charlie"] = "555-555-5555";

            Console.WriteLine($"Alice's Phone: {phonebook["Alice"]}");
            Console.WriteLine($"Bob's Phone: {phonebook["Bob"]}");
        }
       
    }
}

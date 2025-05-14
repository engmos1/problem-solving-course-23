using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem33
    {
        //Problem 33:Translate Words Between Languages.

        static void Main1()
        {
            Dictionary<string ,  string> translations = new Dictionary<string, string>();

            translations.Add("Hello", "Hola");
            translations.Add("World", "Mundo");
            translations.Add("Goodbye", "Adios");

            Console.WriteLine($"Hello in Spanish: {translations["Hello"]}");
            Console.WriteLine($"Goodbye in Spanish: {translations["Goodbye"]}");

        }
    }
}

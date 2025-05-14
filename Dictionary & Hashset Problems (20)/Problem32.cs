using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem32
    {
        //Problem 32: Store Book Information.

        static void Main1()
        {
            Dictionary<string , (string Title, string Author)> BookInformation = new Dictionary<string, (string, string)>();

            BookInformation.Add("978-3-16-148410-0", ("The Great Gatsby", "F. Scott Fitzgerald"));
            BookInformation.Add("978-1-61-729494-5", ("C# in Depth", "Jon Skeet"));


            foreach (var book in BookInformation)
            {
                Console.WriteLine($"ISBN: {book.Key}, Title: {book.Value.Title}, Author: {book.Value.Author}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{
    class Problem61
    {
        //Problem 61: Real-Time Leaderboard


        static void Main1()
        {
            SortedList<string, int> leaderboard = new SortedList<string, int>
        {
            { "Alice", 1200 },
            { "Charlie", 1500 },
            { "Bob", 1300 }
        };

            foreach (var player in leaderboard)
            {
                Console.WriteLine($"Player: {player.Key}, Score: {player.Value}");
            }
        }
    }
}

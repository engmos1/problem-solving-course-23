using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem77
    {
        //Problem 77: Track Player Stats in a Game.

        
        static void Main1()
        {
           (string playerName, int score, int level) playerStats = ("Mostafa Nasreldin", 1500, 5);
           
            // Print the values
            Console.WriteLine($"Player Name: {playerStats.playerName}");
            Console.WriteLine($"Score: {playerStats.score}");
            Console.WriteLine($"Level: {playerStats.level}");

        }
    }
}

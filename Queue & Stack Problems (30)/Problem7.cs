using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem7
    {
        // Problem 7: Implementing Simple Backtracking
        static void Main1()
        {
            Stack<string> Backtracking = new Stack<string>();

            // Simulating a simple backtracking process
            Backtracking.Push("Start");
            Backtracking.Push("Go to Gaz Station");
            Backtracking.Push("Go to Super Market");
            Backtracking.Push("Go To Work");
            Backtracking.Push("Go to Cafe");
            Backtracking.Push("Go Home");

            Console.WriteLine("Backtracking Steps:");
            while (Backtracking.Count > 0)
            {
                string currentStep = Backtracking.Pop();
                Console.WriteLine("Back to :"+currentStep);
                // Simulating a backtrack
               Console.WriteLine();
            }

        }
    }
}

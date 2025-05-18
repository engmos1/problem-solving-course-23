using System;
using System.Collections;
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

    class Problem82
    {
        //Problem 82: User Survey Results.

        static void Main1()
        {
            BitArray SurveyResults = new BitArray(5);

            SurveyResults[0] = true; // 1st question
            SurveyResults[1] = false; // 2nd question
            SurveyResults[2] = true; // 3rd question
            SurveyResults[3] = false;
            SurveyResults[4] = true; 
            // Display the survey results
            Console.WriteLine("Survey Results:");
            for (int i = 0; i < SurveyResults.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}: {(SurveyResults[i] ? "Yes" : "No")}");
            }
        }

    }
}

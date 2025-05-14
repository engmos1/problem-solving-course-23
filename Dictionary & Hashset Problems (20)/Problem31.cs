using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem31
    {
        //Problem 31: Store and Retrieve Student Grades.

        static void Main1()
        {
            Dictionary<string, double> studentGrades = new Dictionary<string, double>
        {
            { "Mohamed", 85.5 },
            { "Ali", 90.0 },
            { "Ahmed", 78.5 }
        };
            studentGrades.Add("Mostafa", 95.6);
            Console.WriteLine($"Student: Mostafa, Grade:" + studentGrades["Mostafa"]);
            

        }
    }
}

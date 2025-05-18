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

    class Problem76
    {
        //Problem 76: Return Multiple Values from a Function.
        
        static (string,int ,double) GetStudentInfo()
        {
            string name = "John Doe";
            int age = 20;
            double gpa = 3.5;
            return (name, age, gpa);
        }
        static void Main1()
        {
            // Call the function and store the returned tuple
            var studentInfo = GetStudentInfo();
            // Access the values in the tuple
            string name = studentInfo.Item1;
            int age = studentInfo.Item2;
            double gpa = studentInfo.Item3;
            // Print the values
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"GPA: {gpa}");

        }
    }
}

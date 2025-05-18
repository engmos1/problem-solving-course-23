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

    class Problem78
    {
        //Problem 78: Store and Compare Employee Details.


        static void Main1()
        {
            (string employeeName, int salary, string department) employeeDetails = ("John Doe", 12345, "IT");
            (string employeeName, int salary, string department) anotherEmployeeDetails = ("Jane Smith", 67890, "HR");

            // Print the values
            Console.WriteLine($"Employee Name: {employeeDetails.employeeName}");
            Console.WriteLine($"Employee Salary: {employeeDetails.salary}");
            Console.WriteLine($"Department: {employeeDetails.department}");
            Console.WriteLine($"Another Employee Name: {anotherEmployeeDetails.employeeName}");
            Console.WriteLine($"Another Employee Salary: {anotherEmployeeDetails.salary}");
            Console.WriteLine($"Another Department: {anotherEmployeeDetails.department}");
            // Compare the employee Salary
            if (employeeDetails.salary > anotherEmployeeDetails.salary)
            {
                Console.WriteLine($"{employeeDetails.employeeName} has a higher salary than {anotherEmployeeDetails.employeeName}");
            }
            else if (employeeDetails.salary < anotherEmployeeDetails.salary)
            {
                Console.WriteLine($"{anotherEmployeeDetails.employeeName} has a higher salary than {employeeDetails.employeeName}");
            }
            else
            {
                Console.WriteLine($"{employeeDetails.employeeName} and {anotherEmployeeDetails.employeeName} have the same salary");
            }




        }
    }
}

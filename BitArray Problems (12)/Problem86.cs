using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem86
    {
        //Problem 86: Password Policy Enforcement.

        static void Main1()
        {
            BitArray passwordPolicy = new BitArray(4); // Uppercase, Lowercase, Digit, Special Character


            string password = "Password123!";
            passwordPolicy[0] = password.Any(char.IsUpper); // Uppercase
            passwordPolicy[1] = password.Any(char.IsLower); // Lowercase
            passwordPolicy[2] = password.Any(char.IsDigit); // Digit
            passwordPolicy[3] = password.Any(ch => "!@#$%^&*".Contains(ch)); // Special Character


            bool isValid = passwordPolicy.Cast<bool>().All(bit => bit);
            Console.WriteLine($"Password Valid: {isValid}");

        }

    }
}

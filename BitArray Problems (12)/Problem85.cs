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

    class Problem85
    {
        //Problem 85: Password Strength Checker.
        static void Main1()
        {
            string password = "P@ssw0rd";
            BitArray passwordStrength = new BitArray(4);
            // Check for uppercase letter
            passwordStrength[0] = password.Any(char.IsUpper);
            // Check for lowercase letter
            passwordStrength[1] = password.Any(char.IsLower);
            // Check for digit
            passwordStrength[2] = password.Any(char.IsDigit);
            // Check for special character
            passwordStrength[3] = password.Any(ch => !char.IsLetterOrDigit(ch));
            Console.WriteLine("Password Strength:");
            Console.WriteLine($"Uppercase: {passwordStrength[0]}");
            Console.WriteLine($"Lowercase: {passwordStrength[1]}");
            Console.WriteLine($"Digit: {passwordStrength[2]}");
            Console.WriteLine($"Special Character: {passwordStrength[3]}");

        }

    }
}

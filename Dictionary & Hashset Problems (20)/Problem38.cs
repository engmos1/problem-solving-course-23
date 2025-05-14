using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem38
    {
        //Problem 38: Dynamic Skill Matching.
        public static void Main1()
        {
            HashSet<string> candidateSkills = new HashSet<string> { "C#", "SQL", "JavaScript" };
            HashSet<string> jobRequirements = new HashSet<string> { "C#", "JavaScript", "React" };

            candidateSkills.IntersectWith(jobRequirements);

            Console.WriteLine("Matching Skills: " + string.Join(", ", candidateSkills));

        }

    }
}

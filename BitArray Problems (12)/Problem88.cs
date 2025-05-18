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

    class Problem88
    {
        //Problem 88: Voting System.

        static void Main1()
        {
            BitArray Votes = new BitArray(8);

            //Votets 
            Votes[0] = true;
            Votes[3] = true;
            Votes[6] = true;
            

            int votecount = 0;
            for (int i = 0; i < 8; i++)
            {
                if (Votes[i] == true)
                    votecount++;

            }

            Console.WriteLine("Number of 'Yes' Votes = " + votecount);
           
        }

    }
}

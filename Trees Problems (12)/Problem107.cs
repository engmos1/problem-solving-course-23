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
   
    class Problem107
    {
        //Problem 107: Hierarchical Employee Management.

        class EmployeeNode
        {
            public string Name { get; set; } // Employee's name
            public string Position { get; set; } // Employee's position
            public List<EmployeeNode> Subordinates { get; set; } = new List<EmployeeNode>(); // List of subordinates


            public EmployeeNode(string name, string position)
            {
                Name = name;
                Position = position;
            }


            public void Print(string indent = "")
            {
                Console.WriteLine($"{indent}{Position}: {Name}"); // Print the current employee's position and name
                foreach (var subordinate in Subordinates)
                {
                    subordinate.Print(indent + "  "); // Recursively print subordinates
                }
            }
        }

        static void Main1()
        {
            var ceo = new EmployeeNode("Alice", "CEO");


            // Create VP and Manager under the CEO
            var vp = new EmployeeNode("Bob", "VP of Marketing");
            var manager = new EmployeeNode("Charlie", "Marketing Manager");


            vp.Subordinates.Add(manager); // Add the manager under the VP
            ceo.Subordinates.Add(vp); // Add the VP under the CEO


            vp = new EmployeeNode("Lara", "VP of Technology");
            manager = new EmployeeNode("Tom", "Architect");


            vp.Subordinates.Add(manager); // Add the manager under the VP
            ceo.Subordinates.Add(vp); // Add the VP under the CEO




            // Display the company hierarchy
            Console.WriteLine("Company Hierarchy:");
            ceo.Print();


        }

    }
}

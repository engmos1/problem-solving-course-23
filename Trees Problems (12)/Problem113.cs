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
   
    class Problem113
    {
        //Problem 113: File Permission System.


        class PermissionNode
        {
            public string Name { get; set; } // Name of the file or folder
            public string Permissions { get; set; } // Permissions for this node (e.g., "rwx")
            public List<PermissionNode> Children { get; set; } = new List<PermissionNode>();


            public PermissionNode(string name, string permissions)
            {
                Name = name;
                Permissions = permissions; // If empty, inherits permissions from parent
            }


            // Recursive method to print permissions, applying inheritance from parent with indentation
            public void PrintPermissions(string inheritedPermissions = "", string indent = "")
            {
                // If the current node has its own permissions, use them; otherwise, inherit from the parent
                string effectivePermissions = Permissions == "" ? inheritedPermissions : Permissions;


                // Print the current node with indentation
                Console.WriteLine($"{indent}{Name}: {effectivePermissions}");


                // Recursively print permissions for child nodes with additional indentation
                foreach (var child in Children)
                {
                    child.PrintPermissions(effectivePermissions, indent + "  "); // Increase indentation for children
                }
            }
        }

        static void Main1()
        {
            var root = new PermissionNode("Root", "rwx"); // Root has "rwx" permissions
            var folder1 = new PermissionNode("Folder1", "rw-"); // Folder1 has "rw-" permissions
            var folder2 = new PermissionNode("Folder2", ""); // Folder2 inherits permissions from its parent
            var file1 = new PermissionNode("File1", ""); // File1 inherits permissions from its parent
            var file2 = new PermissionNode("File2", "r--"); // File2 has "r--" permissions


            // Add children to the structure
            root.Children.Add(folder1);
            root.Children.Add(folder2);
            folder1.Children.Add(file1);
            folder2.Children.Add(file2);


            // Print the file permissions for all nodes
            Console.WriteLine("File Permissions:");
            root.PrintPermissions();




        }

    }
}

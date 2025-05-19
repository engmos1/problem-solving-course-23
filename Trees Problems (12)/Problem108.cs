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
   
    class Problem108
    {
        //Problem 108: Directory Size Calculation.

        class DirectoryNode
        {
            public string Name { get; set; } // Directory or file name
            public int Size { get; set; } // File size (0 for directories)
            public List<DirectoryNode> Children { get; set; } = new List<DirectoryNode>(); // Subdirectories or files


            public DirectoryNode(string name, int size)
            {
                Name = name;
                Size = size;
            }


            // Recursive method to calculate the total size of the directory
            public int CalculateTotalSize()
            {
                int totalSize = Size; // Start with the current node's size
                foreach (var child in Children)
                {
                    totalSize += child.CalculateTotalSize(); // Add sizes of all child nodes
                }
                return totalSize;
            }


            public void Print(string indent = "")
            {
                Console.WriteLine($"{indent}{Name} (Size: {Size})");
                foreach (var child in Children)
                {
                    child.Print(indent + "  ");
                }
            }
        }

        static void Main1()
        {
            var root = new DirectoryNode("root", 0);
            var documents = new DirectoryNode("Documents", 0);
            var photos = new DirectoryNode("Photos", 0);


            documents.Children.Add(new DirectoryNode("Resume.docx", 50));
            documents.Children.Add(new DirectoryNode("Project.pdf", 100));


            photos.Children.Add(new DirectoryNode("Vacation.jpg", 200));


            root.Children.Add(documents);
            root.Children.Add(photos);


            // Print directory structure
            Console.WriteLine("Directory Structure:");
            root.Print();


            // Calculate and display total size
            Console.WriteLine($"\nTotal size of the directory: {root.CalculateTotalSize()} bytes");

        }

    }
}

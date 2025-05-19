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
   
    class Problem114
    {
        //Problem 114: Category Hierarchy.

        class CategoryNode
        {
            public string Name { get; set; } // Name of the category
            public List<CategoryNode> SubCategories { get; set; } = new List<CategoryNode>(); // List of subcategories

            public CategoryNode(string name)
            {
                Name = name; // Initialize the category with a name
            }

            // Recursive method to print the category hierarchy
            public void Print(string indent = "")
            {
                Console.WriteLine(indent + Name); // Print the current category
                foreach (var subCategory in SubCategories) // Loop through subcategories
                {
                    subCategory.Print(indent + "  "); // Recursively print subcategories with indentation
                }
            }
        }

        static void Main1()
        {
            var root = new CategoryNode("Electronics"); // Root category
            var mobiles = new CategoryNode("Mobiles"); // Subcategory for mobiles
            var laptops = new CategoryNode("Laptops"); // Subcategory for laptops
            var samsung = new CategoryNode("Samsung"); // Sub-subcategory for Samsung
            var apple = new CategoryNode("Apple"); // Sub-subcategory for Apple

            // Add subcategories
            mobiles.SubCategories.Add(samsung);
            mobiles.SubCategories.Add(apple);
            root.SubCategories.Add(mobiles);
            root.SubCategories.Add(laptops);

            // Print the category hierarchy
            Console.WriteLine("Category Hierarchy:");
            root.Print(); // Start from the root

        }

    }
}

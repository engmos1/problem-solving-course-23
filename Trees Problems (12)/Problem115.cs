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
   
    class Problem115
    {
        //Problem 115: Maximum Depth of a Binary Tree.

        class TreeNode
        {
            public int Value { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }


            public TreeNode(int value)
            {
                Value = value;
            }
        }

        class BinaryTree
        {
            public int MaxDepth(TreeNode root)
            {
                if (root == null) return 0;


                // Recursively calculate depth of left and right subtrees
                int leftDepth = MaxDepth(root.Left);
                int rightDepth = MaxDepth(root.Right);


                // Return the larger depth + 1 (for the current level)
                return Math.Max(leftDepth, rightDepth) + 1;
            }
        }

        static void Main1()
        {
            var tree = new BinaryTree();


            // Build a sample tree
            var root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(5);


            // Calculate and print the maximum depth
            Console.WriteLine($"Maximum Depth: {tree.MaxDepth(root)}");

        }

    }
}

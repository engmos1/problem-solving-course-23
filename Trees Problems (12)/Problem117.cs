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
   
    class Problem117
    {
        //Problem 117: Print the largest value at each level of a binary tree.

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

            public bool AreIdentical(TreeNode root1, TreeNode root2)
            {
                // Base case: both nodes are null
                if (root1 == null && root2 == null) return true;


                // If one is null and the other is not, they are not identical
                if (root1 == null || root2 == null) return false;


                // Check if the current nodes are identical and recursively check subtrees
                return root1.Value == root2.Value
                    && AreIdentical(root1.Left, root2.Left)
                    && AreIdentical(root1.Right, root2.Right);
            }


            // Method to print a tree (in-order traversal)
            public void PrintTree(TreeNode root, string indent = "")
            {
                if (root == null) return;


                PrintTree(root.Left, indent + "  "); // Traverse the left subtree
                Console.WriteLine($"{indent}{root.Value}"); // Print the current node with indentation
                PrintTree(root.Right, indent + "  "); // Traverse the right subtree
            }

            public List<int> LargestValuesAtEachLevel(TreeNode root)
            {
                var result = new List<int>();
                if (root == null) return result;

                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);


                // Perform level-order traversal
                while (queue.Count > 0)
                {
                    int levelSize = queue.Count; // Number of nodes at the current level
                    int maxValue = int.MinValue;


                    // Process all nodes at the current level
                    for (int i = 0; i < levelSize; i++)
                    {
                        var node = queue.Dequeue();
                        maxValue = Math.Max(maxValue, node.Value); // Update max value for this level


                        // Enqueue left and right children
                        if (node.Left != null) queue.Enqueue(node.Left);
                        if (node.Right != null) queue.Enqueue(node.Right);
                    }

                    result.Add(maxValue); // Add the largest value for this level to the result
                }


                return result;
            }
        }

        static void Main()
        {
            var tree = new BinaryTree();


            // Create a sample tree
            var root = new TreeNode(1);
            root.Left = new TreeNode(3);
            root.Right = new TreeNode(2);
            root.Left.Left = new TreeNode(5);
            root.Left.Right = new TreeNode(3);
            root.Right.Right = new TreeNode(9);


            // Print the tree
            Console.WriteLine("Binary Tree:");
            tree.PrintTree(root);


            // Find and print the largest value at each level
            Console.WriteLine("\nLargest Values at Each Level:");
            var largestValues = tree.LargestValuesAtEachLevel(root);
            for (int i = 0; i < largestValues.Count; i++)
            {
                Console.WriteLine($"Level {i + 1}: {largestValues[i]}");
            }

        }

    }
}

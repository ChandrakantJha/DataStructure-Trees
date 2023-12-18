using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Instance of Tree to store integer values
            Tree<int> tree = new Tree<int>();

            tree.root = new TreeNode<int>() { Data = 100 };

            tree.root.Child = new List<TreeNode<int>>()
            {
              new TreeNode<int>() { Data = 50, Parent = tree.root },
              new TreeNode<int>() { Data = 1, Parent = tree.root },
              new TreeNode<int>() { Data = 150, Parent = tree.root },
            };

            tree.root.Child[2].Child = new List<TreeNode<int>>()
            { new TreeNode<int>() { Data= 30, Parent = tree.root.Child[2] }
            };

        }
    }
}

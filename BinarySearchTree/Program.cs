using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create Integer data Tree
            /*
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
            */
            #endregion End creating Integer data tree

            #region Create Person type Tree

            Tree<Person> companyTree = new Tree<Person>();
            companyTree.root = new TreeNode<Person>()
            {
                Data = new Person(100, "Marcin Jamro", "CEO"),
                Parent = null
            };

            companyTree.root.Child = new List<TreeNode<Person>>()
            {
                new TreeNode<Person>()
                {
                    Data = new Person(1, "John Smith", "Head of Development"),
                    Parent = companyTree.root
                },
                new TreeNode<Person>()
                {
                    Data = new Person(50, "Mary Fox", "Head of Research"),
                    Parent = companyTree.root
                },
                new TreeNode<Person>()
                {
                    Data = new Person(150, "Lily Smith", "Head of Sales"),
                    Parent = companyTree.root
                }
            };

            companyTree.root.Child[2].Child = new List<TreeNode<Person>>()
            {
                 new TreeNode<Person>()
                {
                    Data = new Person(30, "Anthony Black", "Sales Specialist"),
                    Parent = companyTree.root.Child[2]
                }
            };
            //jjji
            Console.WriteLine("Done");
            #endregion End creating person type tree
        }
    }
}


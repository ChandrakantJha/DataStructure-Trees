using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        public BinaryTreeNode() => Child = new List<TreeNode<T>>() { null, null };

        /// <summary>
        /// Left Child
        /// </summary>
        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Child[0]; }

            set { Child[0] = value; }
        }

        /// <summary>
        /// Right Child
        /// </summary>
        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Child[1]; }

            set { Child[1] = value; }
        }
    }
}

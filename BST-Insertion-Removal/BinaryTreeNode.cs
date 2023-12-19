using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Insertion_Removal
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        public BinaryTreeNode() => Child = new List<TreeNode<T>>() { null, null };

        /// <summary>
        /// Parent Node
        /// </summary>
        public BinaryTreeNode<T> Parent { get; set; }

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

        /// <summary>
        /// Get height
        /// </summary>
        /// <returns></returns>
        public int GetHeight()
        {
            int height = 1;
            BinaryTreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }

    }
}

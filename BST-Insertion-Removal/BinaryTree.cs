using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Insertion_Removal
{
    public class BinaryTree<T>
    {
        /// <summary>
        /// Root Node
        /// </summary>
        public BinaryTreeNode<T> Root { get; set; }

        /// <summary>
        /// Count of total number of Nodes in a tree
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Method to traverse tree in various modes
        /// </summary>
        /// <param name="node"></param>
        /// <param name="result"></param>
        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
            switch (mode)
            {
                case TraversalEnum.PREORDER:
                    TraversePreOrder(Root, nodes);
                    break;
                case TraversalEnum.INORDER:
                    TraverseInOrder(Root, nodes);
                    break;
                case TraversalEnum.POSTORDER:
                    TraversePostOrder(Root, nodes);
                    break;
            }
            return nodes;
        }

        /// <summary>
        /// Get height of the tree
        /// </summary>
        /// <param name="node"></param>
        /// <param name="result"></param>
        public int GetHeight()
        {
            int height = 0;
            foreach (BinaryTreeNode<T> node in Traverse(TraversalEnum.PREORDER))
            {
                height = Math.Max(height, node.GetHeight());
            }
            return height;
        }

        private void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }

        private void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }

        private void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class TreeNode<T>
    {
        /// <summary>
        /// Data stored in the node of Type T
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Reference to Parent Node
        /// </summary>
        public TreeNode<T> Parent { get; set; }

        /// <summary>
        /// Collection of References to Child Nodes
        /// </summary>
        public List<TreeNode<T>> Child { get; set; }

        /// <summary>
        /// Returns height of the Node(distance to the root node)
        /// </summary>
        /// <returns></returns>
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null) //go up from Node until there is no parent element( when root is reached)
            {
               height++;
               current = current.Parent;
            }
            return height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /// <summary>
    /// Represents the whole tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Tree<T>
    {
        /// <summary>
        /// property to get access to the root node
        /// </summary>
        public TreeNode<T> root { get; set; }
    }   
}

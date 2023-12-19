using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApp
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
    }
}

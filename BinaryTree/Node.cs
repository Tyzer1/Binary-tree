using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public Node? Parent { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public int Value { get; set; }

        public Node(int value, Node? root = null, Node? left = null, Node? right = null)
        {
            Parent = root;
            Left = left;
            Right = right;
            Value = value;
        }
    }
}

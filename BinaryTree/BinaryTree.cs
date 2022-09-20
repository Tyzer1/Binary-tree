using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinaryTree
{
    public class BinaryTree
    {
        public List<Node> nodes { get; }

        private Node? _root;
        public Node? Root
        {
            get { return _root; }
        }

        public BinaryTree()
        {
            nodes = new List<Node>();
        }

        public void InsertNode(Node newNode)
        {
            nodes.Add(newNode);
            Node? y = null;
            Node? x = _root;

            while (x != null)
            {
                y = x;
                if (newNode.Value < x.Value)
                    x = x.Left;
                else
                    x = x.Right;
            }

            newNode.Parent = y;
            if (y == null)
                _root = newNode;
            else if (newNode.Value < y.Value)
                y.Left = newNode;
            else
                y.Right = newNode;
        }

        public Node? FindNode(int value, Node? tree)
        {
            if (tree == null || tree.Value == value)
                return tree;

            if (value < tree.Value)
                return FindNode(value, tree.Left);
            else
                return FindNode(value, tree.Right);
        }

        public static Node? FindMin(Node root)
        {
            if (root == null) return null;
            while (root.Left != null)
                root = root.Left;
            return root;
        }

        public static Node? FindMax(Node root)
        {
            if (root == null) return null;
            while (root.Right != null)
                root = root.Right;
            return root;
        }

        public void Transplant(Node? oldRoot, Node? newRoot)
        {
            if (oldRoot == null)
                _root = newRoot;
            else if (oldRoot == oldRoot.Parent.Left)
                oldRoot.Parent.Left = newRoot;
            else oldRoot.Parent.Right = newRoot;

            if (newRoot != null)
                newRoot.Parent = oldRoot.Parent;
        }

        public void Delete(Node nodeToDelete)
        {
            if (nodeToDelete.Left == null)
                Transplant(nodeToDelete, nodeToDelete.Right);
            else if (nodeToDelete.Right == null)
                Transplant(nodeToDelete, nodeToDelete.Left);
            else
            {
                var nextNode = FindMin(nodeToDelete.Right);
                if (nextNode.Parent != nodeToDelete)
                {
                    Transplant(nextNode, nextNode.Right);
                    nextNode.Right = nodeToDelete.Right;
                    nextNode.Right.Parent = nextNode;
                }
                Transplant(nodeToDelete, nextNode);
                nextNode.Left = nodeToDelete.Left;
                nextNode.Left.Parent = nextNode;
            }
        }
    }
}

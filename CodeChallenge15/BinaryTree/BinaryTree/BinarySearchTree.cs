using BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree : BinaryTree
    {

        public void Add(int value)
        {
            Root = AddNode(Root, value);
        }
        private Node AddNode(Node node, int value)
        {
            if (node == null)
                return new Node(value);


            if (value.CompareTo(node.Value) < 0)
                node.Left = AddNode(node.Left, value);

            else if (value.CompareTo(node.Value) > 0)
                node.Right = AddNode(node.Right, value);

            return node;
        }

        public bool Contains(int value)
        {
            return ContainsNode(Root, value);
        }

        private bool ContainsNode(Node node, int value)
        {
            if (node == null)
                return false;

            int compareResult = value.CompareTo(node.Value);

            if (compareResult == 0)
                return true;
            else if (compareResult < 0)
                return ContainsNode(node.Left, value);
            else
                return ContainsNode(node.Right, value);
        }

    }
}
using BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public List<int> PreOrderTravarsel()
        {
            List<int> result = new List<int>();
            PreOrderTravarsel(Root, result);

            return result;
        }

        public void PreOrderTravarsel(Node node, List<int> result)
        {
            if (node != null)
            {
                result.Add(node.Value);

                PreOrderTravarsel(node.Left, result);

                PreOrderTravarsel(node.Right, result);
            }

        }

        // In-order Traversal
        public List<int> InorderTraversal()
        {
            List<int> result = new List<int>();
            InorderTraversal(Root, result);
            return result;
        }

        private void InorderTraversal(Node node, List<int> result)
        {
            if (node != null)
            {
                InorderTraversal(node.Left, result);
                result.Add(node.Value);
                InorderTraversal(node.Right, result);
            }
        }

        // Post-order Traversal
        public List<int> PostorderTraversal()
        {
            List<int> result = new List<int>();
            PostorderTraversal(Root, result);
            return result;
        }

        private void PostorderTraversal(Node node, List<int> result)
        {
            if (node != null)
            {
                PostorderTraversal(node.Left, result);
                PostorderTraversal(node.Right, result);
                result.Add(node.Value);
            }
        }

        public int FindMax() {

            var x = PostorderTraversal();
            int temp = 0;

            for (int i = 0; i < x.Count; i++)
            {
                if (temp <  x[i])
                {
                    temp = x[i];
                }
            }
            return temp;

        }



    }
}
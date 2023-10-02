using CodeChallenge32;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeChallenge32
{
    public class TreeIntersection
    {
        public static HashSet<int> treeIntersection(BinarySearchTree tree1, BinarySearchTree tree2)
        {
            HashSet<int> intersection = new HashSet<int>();

            HashSet<int> set1 = setTreeToHash(tree1);
            HashSet<int> set2 = setTreeToHash(tree2);

            foreach (var item in set1)
            {
                if (set2.Contains(item))
                {
                    intersection.Add(item);
                }
            }

            return intersection;
        }

        public static HashSet<int> setTreeToHash(BinarySearchTree bt)
        {
            HashSet<int> nodeSet = new HashSet<int>();

            Queue<Node> queue = new Queue<Node>();
            if (bt.root != null)
            {
                queue.Enqueue(bt.root);

                while (queue.Count > 0)
                {
                    Node currentNode = queue.Dequeue();
                    nodeSet.Add(currentNode.value);

                    if (currentNode.left != null)
                        queue.Enqueue(currentNode.left);

                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                }
            }

            return nodeSet;
        }
    }
}
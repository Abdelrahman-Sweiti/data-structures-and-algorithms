using System.Linq;
using Xunit;
using BinaryTree;
using BinaryTree;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanInstantiateTreeWithSingleRootNode()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(10);
            Assert.Equal(10, tree.Root.Value);
            Assert.Null(tree.Root.Left);
            Assert.Null(tree.Root.Right);
        }

        [Fact]
        public void CanAddLeftAndRightChildToBinarySearchTree()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            Assert.Equal(5, bst.Root.Left.Value);
            Assert.Equal(15, bst.Root.Right.Value);
        }


        [Fact]
        public void CanPerformInOrderTraversal()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            int[] expected = new int[] { 5, 10, 15 };
            int[] result = bst.InorderTraversal().ToArray(); // Convert List<T> to int[]

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanPerformPostOrderTraversal()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            int[] expected = new int[] { 5, 15, 10 };
            int[] result = bst.PostorderTraversal().ToArray(); // Convert List<T> to int[]

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ContainsMethodReturnsTrueForExistingNodeValue()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(5));
            Assert.True(bst.Contains(15));
        }

        [Fact]
        public void ContainsMethodReturnsFalseForNonExistingNodeValue()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            Assert.False(bst.Contains(20));
            Assert.False(bst.Contains(25));
            Assert.False(bst.Contains(30));
        }
    }
}
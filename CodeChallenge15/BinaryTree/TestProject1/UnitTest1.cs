using System.Linq;
using Xunit;
using BinaryTree;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanInstantiateTreeWithSingleRootNode()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node(10);
            Assert.Equal(10, tree.Root.Value);
            Assert.Null(tree.Root.Left);
            Assert.Null(tree.Root.Right);
        }

        [Fact]
        public void CanAddLeftAndRightChildToBinarySearchTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            Assert.Equal(5, bst.Root.Left.Value);
            Assert.Equal(15, bst.Root.Right.Value);
        }


        [Fact]
        public void CanPerformInOrderTraversal()
        {
            BinarySearchTree bst = new BinarySearchTree();
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
            BinarySearchTree bst = new BinarySearchTree();
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
            BinarySearchTree bst = new BinarySearchTree();
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
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            Assert.False(bst.Contains(20));
            Assert.False(bst.Contains(25));
            Assert.False(bst.Contains(30));
        }




    }
}
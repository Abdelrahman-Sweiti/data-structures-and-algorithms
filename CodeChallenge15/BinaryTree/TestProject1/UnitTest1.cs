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


       
        
            BreadthFirst MyBF = new BreadthFirst();
            //Test 1
            [Fact]
            public void Test1()
            {
                BinaryTree2 NewTree = new BinaryTree2();
                NewTree.Root = (new Node(5));
                NewTree.Root.Left = (new Node(10));
                NewTree.Root.Right = (new Node(15));
                NewTree.Root.Left.Left = (new Node(20));
                NewTree.Root.Left.Right = (new Node(25));
                NewTree.Root.Right.Left = (new Node(30));
                NewTree.Root.Right.Right = (new Node(35));
                NewTree.Root.Left.Left.Right = (new Node(1));
                List<int> MyList = new List<int> { 5, 10, 15, 20, 25, 30, 35, 1 };
                Assert.Equal(MyList, MyBF.BreadthFirstMethod(NewTree));
            }

            //Test 2
            [Fact]
            public void Test2()
            {
                BinaryTree2 NewTree = new BinaryTree2();
                NewTree.Root = (new Node(-9));
                NewTree.Root.Left = (new Node(-100));
                NewTree.Root.Right = (new Node(15));
                NewTree.Root.Left.Left = (new Node(2));

                NewTree.Root.Right.Left = (new Node(30));
                NewTree.Root.Right.Left.Left = (new Node(35));
                NewTree.Root.Left.Left.Right = (new Node(1));
                List<int> MyList = new List<int> { -9, -100, 15, 2, 30, 1, 35 };
                Assert.Equal(MyList, MyBF.BreadthFirstMethod(NewTree));
            }
           

        }
}
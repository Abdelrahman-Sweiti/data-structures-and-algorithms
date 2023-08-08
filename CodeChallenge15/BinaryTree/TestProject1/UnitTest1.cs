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


        [Fact]
        public void FindMax_Returns_MaximumValue()
        {
            // Arrange
            BinaryTree2 binaryTree = new BinaryTree2();
            binaryTree.Root = new Node(10);
            binaryTree.Root.Left = new Node(5);
            binaryTree.Root.Right = new Node(20);
            binaryTree.Root.Left.Left = new Node(3);
            binaryTree.Root.Left.Right = new Node(8);
            binaryTree.Root.Right.Left = new Node(15);
            binaryTree.Root.Right.Right = new Node(25);

            // Act
            int maxValue = binaryTree.FindMax();

            // Assert
            Assert.Equal(25, maxValue);
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


        [Fact]
        public void TestKayTree1()
        {
            FizzBuzzNode FirstNode = new FizzBuzzNode(100);
            K_Ary_Tree MyTree = new K_Ary_Tree(FirstNode);

            FizzBuzzNode child1 = new FizzBuzzNode(2);
            FizzBuzzNode child2 = new FizzBuzzNode(1);
            MyTree.Root.AddChild(child1);
            MyTree.Root.AddChild(child2);
            FizzBuzzNode child3 = new FizzBuzzNode(4);
            FizzBuzzNode child4 = new FizzBuzzNode(20);

            child1.AddChild(child3);
            child1.AddChild(child4);
            FizzBuzzNode child5 = new FizzBuzzNode(3);
            child2.AddChild(child5);
            FizzBuzzNode child6 = new FizzBuzzNode(17);
            FizzBuzzNode child7 = new FizzBuzzNode(15);
            child5.AddChild(child6);
            child5.AddChild(child7);
            List<string> MyList = new List<string>();
            MyList = MyTree.FizzBuzzTreeMethod(MyTree);
            List<string> MyExpected = new List<string>() { "Buzz", "2", "1", "4", "Buzz", "Fizz", "17", "FizzBuzz" };
            Assert.Equal(MyList, MyExpected);
        }
        //Test2 Test numbers not fizz or buzz or fizz buzz
        [Fact]
        public void TestKayTree2()
        {
            FizzBuzzNode FirstNode = new FizzBuzzNode(101);
            K_Ary_Tree MyTree = new K_Ary_Tree(FirstNode);

            FizzBuzzNode child1 = new FizzBuzzNode(2);
            FizzBuzzNode child2 = new FizzBuzzNode(1);
            MyTree.Root.AddChild(child1);
            MyTree.Root.AddChild(child2);
            FizzBuzzNode child3 = new FizzBuzzNode(4);
            FizzBuzzNode child4 = new FizzBuzzNode(212);

            child1.AddChild(child3);
            child1.AddChild(child4);


            List<string> MyList = new List<string>();
            MyList = MyTree.FizzBuzzTreeMethod(MyTree);
            List<string> MyExpected = new List<string>() { "101", "2", "1", "4", "212", };
            Assert.Equal(MyList, MyExpected);
        }

        [Fact]
        public void testKayTree3()
        {
            FizzBuzzNode firstnode = new FizzBuzzNode(43);
            K_Ary_Tree MyTree = new K_Ary_Tree(firstnode);

            FizzBuzzNode child1 = new FizzBuzzNode(5);
            FizzBuzzNode child2 = new FizzBuzzNode(3);
            MyTree.Root.AddChild(child1);
            MyTree.Root.AddChild(child2);
            FizzBuzzNode child3 = new FizzBuzzNode(87);
            FizzBuzzNode child4 = new FizzBuzzNode(9);

            child1.AddChild(child3);
            child1.AddChild(child4);
            FizzBuzzNode child5 = new FizzBuzzNode(345);
            child2.AddChild(child5);
            FizzBuzzNode child6 = new FizzBuzzNode(97);
            FizzBuzzNode child7 = new FizzBuzzNode(5);
            child5.AddChild(child6);
            child5.AddChild(child7);
            List<string> MyList = new List<string>();
            MyList = MyTree.FizzBuzzTreeMethod(MyTree);
            List<string> MyExpected = new List<string>() { "43", "Buzz", "Fizz", "Fizz", "Fizz", "FizzBuzz", "97", "Buzz" };
            Assert.Equal(MyList, MyExpected);
        }


    }
}
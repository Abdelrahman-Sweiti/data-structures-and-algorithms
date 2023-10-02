using CodeChallenge32;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class TreeIntersectionTests
    {
        [Fact]
        public void treeIntersection_ReturnsIntersection_WhenValidTreesProvided()
        {
            // Arrange
            BinarySearchTree tree1 = new BinarySearchTree();
            BinarySearchTree tree2 = new BinarySearchTree();

            tree1.Add(5);
            tree1.Add(3);
            tree1.Add(8);

            tree2.Add(5);
            tree2.Add(2);
            tree2.Add(7);

            // Act
            var intersection = TreeIntersection.treeIntersection(tree1, tree2);

            // Assert
            Assert.Contains(5, intersection);
            Assert.Equal(1, intersection.Count);
        }

        [Fact]
        public void setTreeToHash_ReturnsCorrectHashSet_WhenValidTreeProvided()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(5);
            tree.Add(3);
            tree.Add(8);

            // Act
            var result = TreeIntersection.setTreeToHash(tree);

            // Assert
            Assert.Contains(5, result);
            Assert.Contains(3, result);
            Assert.Contains(8, result);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void setTreeToHash_ReturnsEmptyHashSet_WhenEmptyTreeProvided()
        {
            // Arrange
            BinarySearchTree tree = new BinarySearchTree();

            // Act
            var result = TreeIntersection.setTreeToHash(tree);

            // Assert
            Assert.Empty(result);
        }
    }
}
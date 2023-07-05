using System;
using Xunit;
using CodeChallenge07;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void KthFromEnd_WhenKIsGreaterThanLength_ShouldThrowException()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(1);
            linkedList.Append(3);
            linkedList.Append(8);
            linkedList.Append(2);
            int k = 6;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => linkedList.KthFromEnd(k));
        }

        [Fact]
        public void KthFromEnd_WhenKAndLengthAreTheSame_ShouldReturnHeadValue()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(1);
            int k = 1;

            // Act
            int result = linkedList.KthFromEnd(k);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void KthFromEnd_WhenKIsNotPositiveInteger_ShouldThrowException()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(1);
            linkedList.Append(3);
            int k = -1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => linkedList.KthFromEnd(k));
        }

        [Fact]
        public void KthFromEnd_WhenLinkedListSizeIs1_ShouldReturnHeadValue()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(5);
            int k = 0;

            // Act
            int result = linkedList.KthFromEnd(k);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void KthFromEnd_WhenKIsInMiddleOfLinkedList_ShouldReturnCorrectValue()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(1);
            linkedList.Append(3);
            linkedList.Append(8);
            linkedList.Append(2);
            int k = 2;

            // Act
            int result = linkedList.KthFromEnd(k);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
    

using System;
using Xunit;
using CodeChallenge06;
using System.Collections.Generic;
using static CodeChallenge06.Program;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            Assert.Equal(3, list.head.Value);
        }

        [Fact]
        public void HeadPointsToFirstNode()
        {
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.Insert(1);
            Assert.Equal(1, list.head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodesIntoLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            Assert.Equal("1 -> 2 -> 3 -> NULL", list.ToString());
        }

        [Fact]
        public void IncludesReturnsTrueForExistingValue()
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            Assert.True(list.Includes(2));
        }

        [Fact]
        public void IncludesReturnsFalseForNonExistingValue()
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            Assert.False(list.Includes(4));
        }

        [Fact]
        public void GetAllValuesReturnsAllValuesInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            Assert.Equal("1 -> 2 -> 3 -> NULL", list.ToString());
        }

        [Fact]
        public void CanAppendNodeToEndOfLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Append(2);
            Assert.Equal("1 -> 2 -> NULL", list.ToString());
        }

        [Fact]
        public void CanAppendMultipleNodesToEndOfLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Append(2);
            list.Append(3);
            Assert.Equal("1 -> 2 -> 3 -> NULL", list.ToString());
        }

        [Fact]
        public void CanInsertNodeBeforeMiddleNodeOfLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(3);
            list.InsertBefore(3, 2);
            Assert.Equal("1 -> 2 -> 3 -> NULL", list.ToString());
        }

        [Fact]
        public void CanInsertNodeBeforeFirstNodeOfLinkedList()
        {
            LinkedList list = new LinkedList();

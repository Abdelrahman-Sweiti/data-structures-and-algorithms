using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            Assert.Equal(3, list.Head.Value);
        }

        [Fact]
        public void HeadPointsToFirstNode()
        {
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.Insert(1);
            Assert.Equal(1, list.Head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodesIntoLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            Assert.Equal("1 -> 2 -> 3 -> NULL", list.GetAllValues());
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
            Assert.Equal("1 -> 2 -> 3 -> NULL", list.GetAllValues());
        }

        [Fact]
        public void CanAppendNodeToEndOfLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Append(2);
            Assert.Equal("1 -> 2 -> NULL", list.GetAllValues());
        }

        [Fact]
        public void CanAppendMultipleNodesToEndOfLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Append(2);
            list.Append(3);
            Assert.Equal("1 -> 2 -> 3 -> NULL", list.GetAllValues());
        }

        [Fact]
        public void CanInsertNodeBeforeMiddleNodeOfLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(3);
            list.InsertBefore(3, 2);
            Assert.Equal("1 -> 2 -> 3 -> NULL", list.GetAllValues());
        }

        [Fact]
        public void CanInsertNodeBeforeFirstNodeOfLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.InsertBefore(2, 1);
            Assert.Equal("1 -> 2 -> NULL", list.GetAllValues());
        }

        [Fact]
        public void CanInsertNodeAfterMiddleNodeOfLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(3);
            list.InsertAfter(1, 2);
            Assert.Equal("1 -> 2 -> 3 -> NULL", list.GetAllValues());
        }

        [Fact]
        public void CanInsertNodeAfterLastNodeOfLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.InsertAfter(2, 3);
            Assert.Equal("1 -> 2 -> 3 -> NULL", list.GetAllValues());
        }

        public class LinkedList
        {
            public Node Head { get; set; }

            public LinkedList()
            {
                Head = null;
            }

            public void Insert(int value)
            {
                Node newNode = new Node(value);
                newNode.Next = Head;
                Head = newNode;
            }

            public bool Includes(int value)
            {
                Node current = Head;
                while (current != null)
                {
                    if (current.Value == value)
                        return true;
                    current = current.Next;
                }
                return false;
            }

            public string GetAllValues()
            {
                Node current = Head;
                string result = "";
                while (current != null)
                {
                    result += $"{current.Value} -> ";
                    current = current.Next;
                }
                result += "NULL";
                return result;
            }

            public void Append(int value)
            {
                Node newNode = new Node(value);
                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            public void InsertBefore(int targetValue, int newValue)
            {
                if (Head == null)
                    return;

                if (Head.Value == targetValue)
                {
                    Insert(newValue);
                    return;
                }

                Node current = Head;
                while (current.Next != null)
                {
                    if (current.Next.Value == targetValue)
                    {
                        Node newNode = new Node(newValue);
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return;
                    }
                    current = current.Next;
                }
            }

            public void InsertAfter(int targetValue, int newValue)
            {
                Node current = Head;
                while (current != null)
                {
                    if (current.Value == targetValue)
                    {
                        Node newNode = new Node(newValue);
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return;
                    }
                    current = current.Next;
                }
            }


            //it wont read the Node class from the main so i pasted it here for testing
            public class Node
            {
                public int Value { get; set; }
                public Node Next { get; set; }

                public Node(int value)
                {
                    Value = value;
                    Next = null;
                }
            }
        }
    }
}

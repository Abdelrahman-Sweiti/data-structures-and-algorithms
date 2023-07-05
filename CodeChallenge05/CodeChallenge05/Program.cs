using System;

namespace CodeChallenge05
{
    class Program
    {
        class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }

        class LinkedList
        {
            private Node head;

            public LinkedList()
            {
                head = null;
            }

            public void Insert(int value)
            {
                Node newNode = new Node(value);
                newNode.Next = head;
                head = newNode;
            }

            public bool Includes(int value)
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Value == value)
                        return true;
                    current = current.Next;
                }
                return false;
            }

            public override string ToString()
            {
                Node current = head;
                string result = "";
                while (current != null)
                {
                    result += $"{current.Value} -> ";
                    current = current.Next;
                }
                result += "NULL";
                return result;
            }
        }

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            Console.WriteLine(list.ToString()); // Output: 1 -> 2 -> 3 -> NULL
            Console.WriteLine(list.Includes(2)); // Output: True
            Console.WriteLine(list.Includes(4)); // Output: False
        }
    }
}

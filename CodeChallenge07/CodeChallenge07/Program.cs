using System;

namespace CodeChallenge07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            // Add nodes to the linked list
            linkedList.Append(1);
            linkedList.Append(3);
            linkedList.Append(8);
            linkedList.Append(2);

            int k = 2;

            try
            {
                int kthValue = linkedList.KthFromEnd(k);
                Console.WriteLine($"The k-th value from the end of the linked list is: {kthValue}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

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

    public class LinkedList
    {
        public Node Head { get; set; }

        public void Append(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public int KthFromEnd(int k)
        {
            if (k < 0)
            {
                throw new ArgumentException("k must be a positive integer.");
            }

            if (Head == null)
            {
                throw new InvalidOperationException("Linked list is empty.");
            }

            Node slow = Head;
            Node fast = Head;

            for (int i = 0; i < k; i++)
            {
                fast = fast.Next;

                if (fast == null && i < k - 1)
                {
                    throw new ArgumentException("k is greater than the length of the linked list.");
                }
            }

            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow.Value;
        }

    }
}

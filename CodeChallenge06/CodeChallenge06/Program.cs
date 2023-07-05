using System;

namespace CodeChallenge06
{
     public class Program
    {
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
            public Node head;

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

            public void Append(int value)
            {
                Node newNode = new Node(value);

                if (head == null)
                {
                    head = newNode;
                    return;
                }

                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }

            public void InsertBefore(int targetValue, int newValue)
            {
                Node newNode = new Node(newValue);

                if (head == null)
                {
                    throw new InvalidOperationException("List is empty.");
                }

                if (head.Value == targetValue)
                {
                    newNode.Next = head;
                    head = newNode;
                    return;
                }

                Node current = head;
                while (current.Next != null)
                {
                    if (current.Next.Value == targetValue)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return;
                    }
                    current = current.Next;
                }

                throw new InvalidOperationException($"Target value '{targetValue}' not found in the list.");
            }

            public void InsertAfter(int targetValue, int newValue)
            {
                Node newNode = new Node(newValue);

                if (head == null)
                {
                    throw new InvalidOperationException("List is empty.");
                }

                Node current = head;
                while (current != null)
                {
                    if (current.Value == targetValue)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return;
                    }
                    current = current.Next;
                }

                throw new InvalidOperationException($"Target value '{targetValue}' not found in the list.");
            }
        }

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            Console.WriteLine(list.ToString());  
            Console.WriteLine(list.Includes(2)); 
            Console.WriteLine(list.Includes(4));  

            list.Append(5);
            Console.WriteLine(list.ToString()); 

            list.InsertBefore(3, 4);
            Console.WriteLine(list.ToString()); 

            list.InsertAfter(2, 6);
            Console.WriteLine(list.ToString()); 
        }
    }
}

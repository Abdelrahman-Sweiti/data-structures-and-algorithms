using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;


        public LinkedList() {
            Head = null;
            Tail = null;
        }



        public void Add(int data) {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;

            }
            else {
                Node currentNode = Head;

                while (currentNode.next != null) {

                    currentNode = currentNode.next;

                }
                Tail.next = newNode;
                Tail = newNode;
            }

        }

        public void Delete(int target)
        {
            if (Head == null)
            {
                // The list is empty, nothing to delete.
                return;
            }

            if (Head.Data == target)
            {
                // If the target is in the head node, remove the head.
                Head = Head.next;
                return;
            }

            Node current = Head;
            Node previous = null;

            while (current != null)
            {
                if (current.Data == target)
                {
                    // Found the node with the target data. Update references to remove it.
                    previous.next = current.next;
                    return;
                }

                // Move to the next node while keeping track of the previous node.
                previous = current;
                current = current.next;
            }
        }



        public bool Check(LinkedList list)
        {

            if (list.Head == null)
            {
                return true;
            }
            Node currentNode = list.Head;

            while (currentNode.next != null)
            {
                if (currentNode.Data > currentNode.next.Data)
                {
                    return false;
                }
                currentNode = currentNode.next;

            }
            return true;


        }


        public void AddFromTail(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            Node lastNode = Tail;
            Tail.next = newNode;
            Tail = newNode;




        }


        public bool includes(int target)
        {
            if (Head == null)
            {
                return false;
            }

            if (Head.Data == target)
            {
                return true;
            }


            Node current = Head;

            while (current != null)
            {
                if (current.Data == target)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }


        public string PrintListAsString()
        {
            string values = "";
            if (Head == null)
            {
                return "list is empty !";
            }

            Node current = Head;

            while (current != null)
            {
                values += $"[{current.Data.ToString()}] =>";
                current = current.next;
            }
            values += "NULL";
            return values;

        }


        public void InsertBefore(int target, int newValue) {
            if (Head == null)
            {
                return;
            }

            Node current = Head;
            Node New = new Node(newValue);
            if (Head.Data == target)
            {
                Head = New;
                Head.next = current;
                return;
            }

            while (current.next != null)
            {
                if (current.next.Data == target)
                {
                    New.next = current.next;
                    current.next = New;
                    break;
                }

                current = current.next;
            }

        }


        public void InsertAfter(int target, int newValue)
        {
            if (Head == null)
            {
                return;
            }

            Node current = Head;

            Node New = new Node(newValue);
            if (Head.Data == target)
            {
                New.next = Head.next.next;
                Head.next = New;
                New.next = current.next.next;
                return;
            }

            while (current.next != null)
            {
                if (current.next.Data == target)
                {
                    New.next = current.next.next;
                    current.next.next = New;
                    break;
                }

                current = current.next;
            }

        }

        public void ReturnMiddle()
        {
            int x = 0;
            if (Head == null)
            {
                return;
            }
            Node current = Head;
            Node current1 = Head;

            while (current != null)
            {


                current = current.next;
                x++;
            }


            x = x / 2;
            int y = 0;


            while (current1.next != null)
            {
                if (y == x)
                {
                    Console.WriteLine(current1.Data.ToString());
                }

                current1 = current1.next;
                y++;

            }

        }

        public LinkedList SwapPosition()
        {
            if (Head == null || Head.next == null)
            {
                return null;
            }

            Node current = Head;
            LinkedList output = new LinkedList();
            while (current != null && current.next != null)
            {
                int temp = current.Data;
                current.Data = current.next.Data;
                output.Add(current.Data);
                current.next.Data = temp;
                output.Add(current.next.Data);


                current = current.next.next;

            }
            return output;

        }


        public int Kth(int k)
        {
            if (Head == null)
            {
                throw new Exception("this linked list is empty !");
            }

            int x = 0;
            Node current = Head;
            Node current1 = Head;
            Node current2 = null;
            while (current != null)
            {
                current = current.next;
                x++;
            }

            if (k >= x)
            {
                throw new Exception("the value of k is out of the length of the linked list");
                return -1;
            }

            while (current1.next != null)
            {
                if (x == k)
                {
                    return current2.Data;
                }
                current2 = current1;
                current1 = current1.next;
                x--;
            }
            return current2.Data;

        }


        public LinkedList ZipList(LinkedList list1, LinkedList list2)
        {
            LinkedList list3 = new LinkedList();
            Node current1 = list1.Head;
            Node current2 = list2.Head;

            if (current1 == null)
            {
                throw new Exception("List 1 is empty");
            }


            if (current2 == null)
            {
                throw new Exception("List 2 is empty");
            }


            while (current1 != null || current2 != null)
            {
                if (current1 != null)
                {
                    list3.Add(current1.Data);

                    current1 = current1.next;


                }
                if (current2 != null)
                {
                    list3.Add(current2.Data);
                    current2 = current2.next;

                }
            }
            return list3;

        }


        //public LinkedList SortList(LinkedList list1)
        //{
        //    LinkedList list2 = new LinkedList();
        //    int x = 0;
        //    Node current1 = list1.Head;
        //    Node current2 = list1.Head;

        //    if (current1 == null)
        //    {
        //        return null;
        //    }

        //    if (current1.next == null)
        //    {
        //        return list1;
        //    }


        //    while (current1 != null)
        //    {

        //        current1 = current1.next;
        //        x++;

        //    }
        //    int min = 0;
        //    while (current2 != null)
        //    {

        //        for (int i = 0; i < x; i++)
        //        {

        //            if (current2.Data < current2.next.Data)
        //            {
        //                min = current2.Data;

        //            }
        //            current2 = current2.next;

        //        }
        //        list2.Add(min);

        //        current2 = current2.next;
        //    }
        //    return list1;
        //}



        public LinkedList MergeSorted(LinkedList list1, LinkedList list2)
        {
            Node current1 = list1.Head;
            Node current2 = list2.Head;
            LinkedList output = new LinkedList();
            if (current1 == null || current2 == null)
            {
                throw new Exception("this list is empty");
            }

            if (current1 == null)
            {
                return list2;
            }
            else if (current2 == null)
            {
                return list1;
            }



            while (current1 != null)
            {

                output.Add(current1.Data);

                current1 = current1.next;

            }

            while (current2 != null)
            {

                output.Add(current2.Data);
                current2 = current2.next;



            }
            return output;

        }


        public LinkedList ReverseList(LinkedList list1)
        { 
        
            Node current = list1.Head;
            LinkedList output = new LinkedList();

            if (current ==null)
            {
                return null;
            }
            Stack<int> stack = new Stack<int>();

            while (current != null) {
                stack.Push(current.Data);
                current = current.next;
            
            }

            while (stack.Count>0)
            {
                output.Add(stack.Pop());
            }
        
            return output;
        }



        public bool CheckCycle(Node test)
        { 
            Node current = test;
            Stack<Node> x = new Stack<Node>();


            while (current!=null)
            {
                if (x.Contains(current))
                {
                    return true;
                }
                x.Push(current);
                current = current.next;

            }
            return false;
        
        }

        public bool CheckIfPal(LinkedList list) {

            Node current = list.Head;
            Node current2 = list.Head;

            Stack<int> stack = new Stack<int>();

            while (current != null)
            {

                stack.Push(current.Data);
                current = current.next;
            }

            while (current2 != null) {

                if (stack.Pop() != current2.Data)
                {
                    return false;
                }
            
                current2 = current2.next;
            }
            return true;
        
        }


        public int CalcSecondLargest(LinkedList list)
        {
            Node current = list.Head;

            if (current==null || current.next==null)
            {
                return -1;
            }

            int Max1 = 0;
            int Max2 = 0;
            while (current!=null)
            {
                if (current.Data>Max1)
                {
                    Max2 = Max1;
                    Max1 = current.Data;
                }
                if (current.Data>Max2 && current.Data<Max1)
                {
                    Max2 = current.Data;
                }

                current = current.next;
            }

            return Max2;
        
        }


    } 
}
    
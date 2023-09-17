
using HashTableImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableImplement
{
    public class LinkedList
    {
        public Node Head { get; set; } = null;
        public Node Current { get; set; }
        public LinkedList() { }
        public LinkedList(Node node)
        {
            Head = node;
        }
        public void Append(Node node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Current = Head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = node;
            }
        }
    }
}
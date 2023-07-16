using System;
using System.Collections.Generic;

namespace CodeChallenge11
{


    public class Stack<T>
    {
        private List<T> items;

        public Stack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                int lastIndex = items.Count - 1;
                T lastItem = items[lastIndex];
                items.RemoveAt(lastIndex);
                return lastItem;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                return items[items.Count - 1];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }

    public class PseudoQueue<T>
    {
        private Stack<T> stack1;
        private Stack<T> stack2;

        public PseudoQueue()
        {
            stack1 = new Stack<T>();
            stack2 = new Stack<T>();
        }

        public void Enqueue(T value)
        {
            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);
            while (!stack2.IsEmpty())
            {
                stack1.Push(stack2.Pop());
            }
        }

        public T Dequeue()
        {
            if (stack1.IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return stack1.Pop();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();
            pseudoQueue.Enqueue(10);
            pseudoQueue.Enqueue(15);
            pseudoQueue.Enqueue(20);

            Console.WriteLine(pseudoQueue.Dequeue()); // Output: 10
            Console.WriteLine(pseudoQueue.Dequeue()); // Output: 15
        }
    }
}
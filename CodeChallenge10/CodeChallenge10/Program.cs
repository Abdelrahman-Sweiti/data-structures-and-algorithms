namespace CodeChallenge10
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

    public class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            int value = top.Value;
            top = top.Next;
            return value;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return top.Value;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

    public class Queue
    {
        private Node front;

        public Queue()
        {
            front = null;
        }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);

            if (IsEmpty())
            {
                front = newNode;
            }
            else
            {
                Node current = front;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");

            int value = front.Value;
            front = front.Next;
            return value;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");

            return front.Value;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }



    public class Program
    {
        public static void Main(string[] args)
        {
            TestStack();
            TestQueue();
        }

        private static void TestStack()
        {
            Stack stack = new Stack();

            stack.Push(5);
            stack.Push(10);
            stack.Push(15);

            Console.WriteLine(stack.Pop()); // Output: 15
            Console.WriteLine(stack.Peek()); // Output: 10
            Console.WriteLine(stack.IsEmpty()); // Output: False

            stack.Pop();
            stack.Pop();

            Console.WriteLine(stack.IsEmpty()); // Output: True

            try
            {
                stack.Pop(); // Throws exception: Stack is empty.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void TestQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);

            Console.WriteLine(queue.Dequeue()); // Output: 5
            Console.WriteLine(queue.Peek()); // Output: 10
            Console.WriteLine(queue.IsEmpty()); // Output: False

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine(queue.IsEmpty()); // Output: True

            try
            {
                queue.Dequeue(); // Throws exception: Queue is empty.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
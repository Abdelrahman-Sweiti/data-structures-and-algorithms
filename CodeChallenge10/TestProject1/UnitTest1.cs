using System;
using Xunit;
using CodeChallenge10;

namespace TestProject1
{

    public class UnitTest1
    {
        [Fact]
        public void TestStackPush()
        {
            Stack stack = new Stack();
            stack.Push(5);
            Assert.Equal(5, stack.Peek());
        }

        [Fact]
        public void TestStackMultiplePush()
        {
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            Assert.Equal(15, stack.Peek());
        }

        [Fact]
        public void TestStackPop()
        {
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(10);
            int poppedValue = stack.Pop();
            Assert.Equal(10, poppedValue);
        }

        [Fact]
        public void TestStackEmpty()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void TestStackPeekException()
        {
            Stack stack = new Stack();
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Fact]
        public void TestStackPopException()
        {
            Stack stack = new Stack();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void TestQueueEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Peek());
        }

        [Fact]
        public void TestQueueMultipleEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);
            Assert.Equal(5, queue.Peek());
        }

        [Fact]
        public void TestQueueDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(10);
            int dequeuedValue = queue.Dequeue();
            Assert.Equal(5, dequeuedValue);
        }

        [Fact]
        public void TestQueueEmpty()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void TestQueuePeekException()
        {
            Queue queue = new Queue();
            Assert.Throws<InvalidOperationException>(() => queue.Peek());
        }

        [Fact]
        public void TestQueueDequeueException()
        {
            Queue queue = new Queue();
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }
    }
}
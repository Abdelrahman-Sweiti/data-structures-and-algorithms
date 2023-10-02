using System;

namespace CodeChallenge32
{
    public class Node
    {
        public Node left { get; set; }
        public Node right { get; set; }
        public int value { get; set; }

        public Node(int value)
        {
            this.value = value;
            left = right = null;
        }
    }
}
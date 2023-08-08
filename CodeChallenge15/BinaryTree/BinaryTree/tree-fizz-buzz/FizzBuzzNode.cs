using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class FizzBuzzNode
    {
        public int Value { get; set; }

        public List<FizzBuzzNode> Children = new List<FizzBuzzNode>() { };
        public FizzBuzzNode(int Value)
        {
            this.Value = Value;

        }
        public List<FizzBuzzNode> getChildren()
        {
            return Children;
        }

        public void AddChild(FizzBuzzNode Child)
        {
            this.Children.Add(Child);
        }
    }
}
using BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BreadthFirst
    {

        //Code Challenge 17

        public List<int> BreadthFirstMethod(BinaryTree2 MyTree)
        {
            if (MyTree.Root == null)
            {
                throw new Exception("This Tree Is Empty !!");
            }
            Node temp = MyTree.Root;
            Queue<Node> MyQueue = new Queue<Node>();
            List<int> MyNewList = new List<int>();
            MyQueue.Enqueue(temp);
            while (MyQueue.Count > 0)
            {
                temp = MyQueue.Dequeue();
                MyNewList.Add(temp.Value);

                if (temp.Left != null)
                {
                    MyQueue.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    MyQueue.Enqueue(temp.Right);
                }
            }
            return MyNewList;
        }

    }
}
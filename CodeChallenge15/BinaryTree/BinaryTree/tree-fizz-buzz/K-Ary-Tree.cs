using BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class K_Ary_Tree
    {
        public FizzBuzzNode Root;
        //public K_Ary_Tree()
        //{
        //    Root.Value = 0;
        //}
        public K_Ary_Tree(FizzBuzzNode newNode)
        {
            Root = newNode;

        }
        public List<string> FizzBuzzTreeMethod(K_Ary_Tree MyKTree)
        {

            Queue<FizzBuzzNode> MyQueue = new Queue<FizzBuzzNode>();
            List<string> MyList = new List<string>();
            // string Result;
            if (MyKTree.Root == null)
            {
                throw new Exception("The Tree Is Empty!!");
            }
            else
            {
                MyQueue.Enqueue(MyKTree.Root);
                while (MyQueue.Count > 0)
                {
                    FizzBuzzNode temp = MyQueue.Dequeue();
                    if (temp.Value % 3 == 0 && temp.Value % 5 == 0)
                    {
                        //Result = "FizzBuzz";
                        MyList.Add("FizzBuzz");
                    }


                    else if (temp.Value % 3 == 0)
                    {
                        // Result = "Fizz";
                        MyList.Add("Fizz");
                    }
                    else if (temp.Value % 5 == 0)
                    {
                        //  Result = "Buzz
                        MyList.Add("Buzz");
                    }

                    else
                    {
                        MyList.Add(temp.Value.ToString());
                        //Result = temp.Value.ToString();
                    }
                    if (temp.Children.Count > 0)
                    {
                        foreach (var child in temp.Children)
                        {
                            MyQueue.Enqueue(child);
                        }
                    }
                }
                return MyList;

            }

        }

    }
}
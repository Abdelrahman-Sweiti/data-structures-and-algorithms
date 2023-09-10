using System.Collections;
using System.Collections.Generic;

namespace LinkedListPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
           LinkedList list = new LinkedList();
           LinkedList list2 = new LinkedList();
           LinkedList list3 = new LinkedList();
           LinkedList list4 = new LinkedList();
          
            
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(2);
            list.Add(1);

            bool kk = list.CheckIfPal(list);
            if (kk)
            {
                Console.WriteLine("\n list is pal");
            }
            else
            {
                Console.WriteLine("\n list is not pal");
            }
            //list.AddFromTail(6);
            //list.AddFromTail(7);
            //list.AddFromTail(8);
            //list.AddFromTail(9);

            var k = list4.ReverseList(list);
            Console.WriteLine(k.PrintListAsString());

            var g = list.SwapPosition();
            Console.WriteLine(g.PrintListAsString());
            list2.Add(6);
            list2.Add(7);
            list2.Add(8);
            list2.Add(9);
            list2.Add(10);

            list2.AddFromTail(6);
            list2.AddFromTail(7);
            list2.AddFromTail(8);
            var t =list3.MergeSorted(list,list2);
            Console.WriteLine(t.PrintListAsString());

            list.SwapPosition();
            //int value = list.Kth(6);
            //Console.WriteLine(value);
            //list.Delete(5);
            list.Check(list);
            //list.InsertBefore(6, 7);
            //list.InsertAfter(1, 99);
            list.ReturnMiddle();
            string x = list.PrintListAsString();
            Console.WriteLine(x);
            bool isSorted = list.Check(list);

            // Output the result
            if (isSorted)
            {
                Console.WriteLine("\n The linked list is sorted.");
            }
            else
            {
                Console.WriteLine("\n The linked list is not sorted.");
            }


            bool isInclude = list.includes(4);

            // Output the result
            if (isInclude)
            {
                Console.WriteLine($"The linked list contains the target");
            }
            else
            {
                Console.WriteLine("The linked list does not contain the target");
            }

        }





    }


   
}
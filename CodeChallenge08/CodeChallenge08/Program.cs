using System;
namespace CodeChallenge08;

public class LinkedListUtils
{
    public static LinkedList<int> ZipTheLinkedLists(LinkedList<int> LinkedList1, LinkedList<int> LinkedList2)
    {
        if (LinkedList1.Count == 0)
            return LinkedList2;
        if (LinkedList2.Count == 0)
            return LinkedList1;

        LinkedList<int> zippedList = new LinkedList<int>();

        var current1 = LinkedList1.First;
        var current2 = LinkedList2.First;

        while (current1 != null && current2 != null)
        {
            zippedList.AddLast(current1.Value);
            zippedList.AddLast(current2.Value);

            current1 = current1.Next;
            current2 = current2.Next;
        }

        while (current1 != null)
        {
            zippedList.AddLast(current1.Value);
            current1 = current1.Next;
        }

        while (current2 != null)
        {
            zippedList.AddLast(current2.Value);
            current2 = current2.Next;
        }

        return zippedList;
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        LinkedList<int> list1 = new LinkedList<int>();
        list1.AddLast(1);
        list1.AddLast(3);
        list1.AddLast(2);

       
        LinkedList<int> list2 = new LinkedList<int>();
        list2.AddLast(5);
        list2.AddLast(9);
        list2.AddLast(4);

        
        LinkedList<int> zippedList = LinkedListUtils.ZipTheLinkedLists(list1, list2);

       
        foreach (var item in zippedList)
        {
            Console.Write(item + " ");
        }
       
    }
}

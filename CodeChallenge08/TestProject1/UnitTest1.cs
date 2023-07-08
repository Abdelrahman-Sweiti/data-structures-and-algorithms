using CodeChallenge08;
using Xunit;

namespace TestProject1;

public class LinkedListUtilsTests
{
    [Fact]
    public void ZipLists_BothListsEmpty_ReturnsEmptyList()
    {
        
        var list1 = new LinkedList<int>();
        var list2 = new LinkedList<int>();

        
        var result = LinkedListUtils.ZipTheLinkedLists(list1, list2);

        
        Assert.Empty(result);
    }

    [Fact]
    public void ZipLists_List1Empty_ReturnsList2Unchanged()
    {
        
        var list1 = new LinkedList<int>();
        var list2 = new LinkedList<int>();
        list2.AddLast(5);
        list2.AddLast(9);
        list2.AddLast(4);

        
        var result = LinkedListUtils.ZipTheLinkedLists(list1, list2);

        
        Assert.Equal(list2, result);
    }

    [Fact]
    public void ZipLists_List2Empty_ReturnsList1Unchanged()
    {
        
        var list1 = new LinkedList<int>();
        list1.AddLast(1);
        list1.AddLast(3);
        list1.AddLast(2);   
        var list2 = new LinkedList<int>();

        
        var result = LinkedListUtils.ZipTheLinkedLists(list1, list2);

       
        Assert.Equal(list1, result);
    }

    [Fact]
    public void ZipLists_ListsSameLength_ReturnsZippedList()
    {
       
        var list1 = new LinkedList<int>();
        list1.AddLast(1);
        list1.AddLast(3);
        list1.AddLast(2);
        var list2 = new LinkedList<int>();
        list2.AddLast(5);
        list2.AddLast(9);
        list2.AddLast(4);
        var expected = new LinkedList<int>();
        expected.AddLast(1);
        expected.AddLast(5);
        expected.AddLast(3);
        expected.AddLast(9);
        expected.AddLast(2);
        expected.AddLast(4);

       
        var result = LinkedListUtils.ZipTheLinkedLists(list1, list2);

       
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ZipLists_List2Longer_ReturnsZippedList()
    {
       
        var list1 = new LinkedList<int>();
        list1.AddLast(1);
        list1.AddLast(3);
        var list2 = new LinkedList<int>();
        list2.AddLast(5);
        list2.AddLast(9);
        list2.AddLast(4);
        var expected = new LinkedList<int>();
        expected.AddLast(1);
        expected.AddLast(5);
        expected.AddLast(3);
        expected.AddLast(9);
        expected.AddLast(4);

       
        var result = LinkedListUtils.ZipTheLinkedLists(list1, list2);

       
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ZipLists_List1Longer_ReturnsZippedList()
    {
        
        var list1 = new LinkedList<int>();
        list1.AddLast(1);
        list1.AddLast(3);
        list1.AddLast(2);
        var list2 = new LinkedList<int>();
        list2.AddLast(5);
        list2.AddLast(9);
        var expected = new LinkedList<int>();
        expected.AddLast(1);
        expected.AddLast(5);
        expected.AddLast(3);
        expected.AddLast(9);
        expected.AddLast(2);

       
        var result = LinkedListUtils.ZipTheLinkedLists(list1, list2);

        
        Assert.Equal(expected, result);
    }
}

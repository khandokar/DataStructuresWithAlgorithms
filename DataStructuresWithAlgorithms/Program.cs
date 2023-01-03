using System;
using System.Collections;
using System.Collections.Generic;
using static DataStructuresWithAlgorithms.MySingleLinkedList;

namespace DataStructuresWithAlgorithms
{
  class Program
  {
    static void Main(string[] args)
    {
      //int[] myNum = { 10, 7, 1, 8, 5, 6, 3, 9, 8, 2 };

      //Quicksort quicksort = new Quicksort();
      //quicksort.Sort(myNum, 0, 9);

      //foreach(int a in myNum)
      //Console.Write(a +" ");


      //int[] arr = { 500, 2, 9, 100, 3, 8, 6, 700 };
      //int arr_size = arr.Length;

      //Mergesort mergesort = new Mergesort();
      //mergesort.Sort(arr, 0, arr_size - 1);

      //foreach(int a in arr)
      //Console.Write(a +" ");

      //MySingleLinkedList msllist = new MySingleLinkedList();
      //msllist.Insert(3);
      //msllist.Insert(2);
      //msllist.Insert(0);
      //msllist.Insert(-4);
      //msllist.MakeCycle(1);
      //bool hasCycle = msllist.HasCycle();
      //Node node = msllist.DetectCycle();
      //Console.WriteLine(node == null ? "" : node.data);

      //msllist.Insert(1);
      //bool hasCycle = msllist.HasCycle();
      //Console.WriteLine(hasCycle);
      //Node node = msllist.DetectCycle();
      //Console.WriteLine(node == null ? "" : node.data);

      //msllist.Insert(1);
      //msllist.Insert(2);
      //msllist.MakeCycle(0);
      //bool hasCycle = msllist.HasCycle();
      //Node node = msllist.DetectCycle();


      //MySingleLinkedList msllist = new MySingleLinkedList();
      //msllist.Insert(2);
      //msllist.Insert(2);
      //msllist.Insert(2);
      //msllist.Insert(3);
      //msllist.Insert(4);
      //msllist.DeleteDuplicates2();
      //msllist.Show();

      //MySingleLinkedList msllist1 = new MySingleLinkedList();
      //msllist1.Insert(2);
      //msllist1.Insert(4);
      //msllist1.Insert(3);

      //MySingleLinkedList msllist2 = new MySingleLinkedList();
      //msllist2.Insert(5);
      //msllist2.Insert(6);
      //msllist2.Insert(4);

      //MySingleLinkedList msllist1 = new MySingleLinkedList();
      //msllist1.Insert(9);
      //msllist1.Insert(9);
      //msllist1.Insert(9);
      //msllist1.Insert(9);
      //msllist1.Insert(9);
      //msllist1.Insert(9);
      //msllist1.Insert(9);

      //MySingleLinkedList msllist2 = new MySingleLinkedList();
      //msllist2.Insert(9);
      //msllist2.Insert(9);
      //msllist2.Insert(9);
      //msllist2.Insert(9);

      //MySingleLinkedList msllist1 = new MySingleLinkedList();
      //msllist1.Insert(0);

      //MySingleLinkedList msllist2 = new MySingleLinkedList();
      //msllist2.Insert(0);

      //msllist.AddTwoNumbers(msllist1.Head, msllist2.Head);
      //msllist.Show();

      /*
      https://leetcode.com/problems/remove-nth-node-from-end-of-list/

      MySingleLinkedList msllist2 = new MySingleLinkedList();
      msllist2.Insert(1);
      msllist2.Insert(2);
      msllist2.Insert(3);
      msllist2.Insert(4);
      msllist2.Insert(5);

      msllist2.RemoveNthFromEnd(2);
      msllist2.Show();

      msllist2 = new MySingleLinkedList();
      msllist2.Insert(1);
      msllist2.Insert(2);

      msllist2.RemoveNthFromEnd(1);
      msllist2.Show();
      */

      /*
      https://leetcode.com/problems/reverse-linked-list/

      MySingleLinkedList msllist2 = new MySingleLinkedList();
      msllist2.Insert(1);
      msllist2.Insert(2);
      msllist2.Insert(3);
      msllist2.Insert(4);
      msllist2.Insert(5);

      msllist2.ReverseList();
      msllist2.Show();

      msllist2 = new MySingleLinkedList();
      msllist2.Insert(1);
      msllist2.Insert(2);

      msllist2.ReverseList();
      msllist2.Show();

      */

      /*
      https://leetcode.com/problems/merge-two-sorted-lists/
      MySingleLinkedList msllist1 = new MySingleLinkedList();
      msllist1.Insert(1);
      msllist1.Insert(2);
      msllist1.Insert(4);

      MySingleLinkedList msllist2 = new MySingleLinkedList();
      msllist2.Insert(1);
      msllist2.Insert(3);
      msllist2.Insert(4);

      MySingleLinkedList msllist = new MySingleLinkedList();
      msllist.MergeTwoLists(msllist1.Head, msllist2.Head);
      msllist2.Show();
      */

      /*
      MySingleLinkedList msllist = new MySingleLinkedList();
      msllist.Insert(1);
      msllist.Insert(2);
      msllist.Insert(3);
      msllist.Insert(4);
      msllist.Insert(5);

      msllist.ReorderList();
      msllist.Show();

      */

      /*
      
      https://leetcode.com/problems/merge-k-sorted-lists/
      MySingleLinkedList msllist1 = new MySingleLinkedList();
      msllist1.Insert(1);
      msllist1.Insert(4);
      msllist1.Insert(5);

      MySingleLinkedList msllist2 = new MySingleLinkedList();
      msllist2.Insert(1);
      msllist2.Insert(3);
      msllist2.Insert(4);

      MySingleLinkedList msllist3 = new MySingleLinkedList();
      msllist3.Insert(2);
      msllist3.Insert(6);

      MySingleLinkedList msllist = new MySingleLinkedList();
      msllist.MergeKListsMerge(new Node[] { msllist1.Head, msllist2.Head, msllist3.Head});
      msllist.Show();

      */

      /*
      https://leetcode.com/problems/kth-largest-element-in-an-array/

      MyArray marray = new MyArray();

      int[] mArray = new int[] { 1, 5, 6, 9, 2 };
      
      int num = marray.FindKthLargest(mArray, 3);

      QuickSelect qs = new QuickSelect();

      num = qs.Select(mArray, 0, 4, 3);

      */


      //int[] mynum = new int[] { 100, 4, 200, 1, 3, 2 };
      //int[] mynum = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
      //MyArray marray = new MyArray();
      //int conNumb = marray.LongestConsecutive(mynum);

      MyArray marray = new MyArray();
      string s = "3[a]2[bc]";
      s = "3[a2[c]]";   
      string result = marray.DecodeString(s);

      //int[] mynum = new int[] { 1,2,3,4 };
      //mynum = new int[] { -1, 1, 0, -3, 3 };
      //MyArray marray = new MyArray();
      //int[] my = marray.ProductExceptSelf(mynum);

    }
  }
}

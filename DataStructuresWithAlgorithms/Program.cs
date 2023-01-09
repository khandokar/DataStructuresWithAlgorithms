using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

      //MyArray marray = new MyArray();
      //string s = "3[a]2[bc]";
      //s = "3[a2[c]]";   
      //string result = marray.DecodeString(s);

      //int[] mynum = new int[] { 1,2,3,4 };
      //mynum = new int[] { -1, 1, 0, -3, 3 };
      //MyArray marray = new MyArray();
      //int[] my = marray.ProductExceptSelf(mynum);

      //string[] s = new string[] {"eat","tea","tan","ate","nat","bat"};
      //var dd = marray.GroupAnagrams(s);

      //foreach(var a in dd)
      //{
      //  Console.WriteLine(a.ToString());
      //}

      //MyArray marray = new MyArray();
      //int[] mynum = new int[] { 2, 7, 11, 15 };
      //int target = 9;
      //int[] result = marray.TwoSum(mynum, target);


      //MyArray marray = new MyArray();
      //string s = "anagram", t = "nagaram";

      //bool b = marray.IsAnagram(s, t);

      //MyArray marray = new MyArray();
      //int[] nums = new int[] { 1, 2, 3, 1 };

      //bool resutl = marray.ContainsDuplicate(nums);


      /*

      BucketSort bucketSort = new BucketSort();

      float[] arr = { (float)0.897, (float)0.565, (float)0.656, (float)0.1234, (float)0.665, (float)0.3434 };

      bucketSort.Sort(arr, 10);

      float[] arr1 = { (float).2, (float)1.2f, (float)3.2f, (float)7.4f, (float)2.3f, (float)5.6f, (float)8.3f, (float)4.7f, (float)6.3f, (float)7.2f, (float)1.1f, (float)40.2f, (float)50.1f, (float)39.1f };

      bucketSort.Sort(arr1, 51);

      int[] arr2 = { 10, 12, 20, 501, 101, 500, 25, 25, 26 };

      bucketSort.Sort(arr2, 501);

      */

      /*
      RadixSort radixSort = new RadixSort();
      //int[] arr = { 4982, 325, 5631, 8962, 5362, 5341, 7282};
      //int[] arr = { 48, 1, 6 ,23, 37, 19, 21 };
      int[] arr = {300, 215, 110, 115, 210, 315, 310, 200, 100 };
      radixSort.Sort(arr, 8962, 10);
      */

      /*
      MyArray marray = new MyArray();
      //int[] arry = { -1, 0, 1, 2, -1, -4 };
      //int[] arry = { 0, 1, 1 };
      int[] arry = { 0, 0, 0 };
      IList<List<int>> ints =   marray.ThreeSum(arry);
      foreach(var v in ints)
      {
        Console.Write("[");
        foreach(var p in v)
        {
          Console.Write(p.ToString());
          Console.Write(" ");
        }
        Console.Write("] ");
      }
      */

      /*
      MyArray marray = new MyArray();
      //int[] arry = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
      int[] arry = { 1, 1 };
      int maxArea = marray.MaxArea(arry);
      Console.Write(maxArea.ToString());
      */

      /* 
      MyArray marray = new MyArray();
       //String s = "A man, a plan, a canal: Panama";
       //String s = "race a car";
       String s = " ";
       bool isPalindrome = marray.IsPalindrome(s);
      Console.Write(isPalindrome);
      */

      /*
       * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
       * Sliding Window
      MyArray marray = new MyArray();
      //int[] arry = { 7, 1, 5, 3, 6, 4 };
      int[] arry = { 7, 6, 4, 3, 1 };
      int maxProfit = marray.MaxProfit(arry);
      Console.WriteLine(maxProfit);
      */
    }
  }
}

﻿using System;
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

      MySingleLinkedList msllist = new MySingleLinkedList();
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

      MySingleLinkedList msllist1 = new MySingleLinkedList();
      msllist1.Insert(0);

      MySingleLinkedList msllist2 = new MySingleLinkedList();
      msllist2.Insert(0);

      msllist.AddTwoNumbers(msllist1.Head, msllist2.Head);
      msllist.Show();
    }
  }
}

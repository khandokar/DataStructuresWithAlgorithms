using System;

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


      int[] arr = { 500, 2, 9, 100, 3, 8, 6, 700 };
      int arr_size = arr.Length;

      Mergesort mergesort = new Mergesort();
      mergesort.Sort(arr, 0, arr_size - 1);

      foreach(int a in arr)
      Console.Write(a +" ");
    }
  }
}

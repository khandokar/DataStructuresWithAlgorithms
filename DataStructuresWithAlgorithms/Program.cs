using System;

namespace DataStructuresWithAlgorithms
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNum = { 10, 7, 1, 8, 5, 6, 3, 9, 8, 2 };

      Quicksort quicksort = new Quicksort();
      quicksort.Sort(myNum, 0, 9);

      foreach(int a in myNum)
      Console.Write(a +" ");
    }
  }
}

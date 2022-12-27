using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{

  // Time Complexity O(nlogn).
  // TODO: Need to read time complexity
  public class Quicksort
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="start"></param>
    /// <param name="stop"></param>
    public void Sort(int[] arr, int start, int stop)
    {
      int p = getMedianIndex(arr, start, stop); // swaps A[p] and A[stop]
      Swap(arr, p, stop);    // swaps A[p] and A[stop]
      int i = start;
      int j = stop-1;
      while (i <= j)     //until j < i
      {
        while (i < stop && arr[i] < arr[stop])
        {
          i++; //move i till you find a number >= pivot
        }

        while (j >= start && arr[j] >= arr[stop])
        {
          j--; //move j till you find a number < pivot
        }

        if (i < j) // no crossover happend
        {
          Swap(arr, i, j);
          i++;
          j--;
        }
      }

      Swap(arr, i, stop);
      if (start < i - 1) Sort(arr, start, i - 1); // call only there are more than 1 item
      if (i + 1 < stop) Sort(arr, i + 1, stop);   // call only there are more than 1 item

    }
    
    /// <summary>
    /// Swap 2 elements in an array
    /// </summary>
    /// <param name="a"></param>
    /// <param name="i"></param>
    /// <param name="j"></param>
    private void Swap(int[] a, int i, int j)
    {
      int temp = a[i];
      a[i] = a[j];
      a[j] = temp;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="start"></param>
    /// <param name="stop"></param>
    /// <returns></returns>
    private int getMedianIndex(int[] arr, int start, int stop)
    {
      int x = arr[start];

      int m = (start + stop) / 2;
      int y = arr[m];

      int z = arr[stop];
      if ((x - y) * (z - x) >= 0)
        return start;
      else if ((y - x) * (z - y) >= 0) 
        return m;
      else
        return stop;
    }
  }

}

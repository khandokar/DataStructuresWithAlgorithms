﻿namespace DataStructuresWithAlgorithms
{
  public class Mergesort
  {
    private void Merge(int[] arr, int start, int mid, int end)
    {
      int start2 = mid + 1;

      // If the direct merge is already sorted
      //if (arr[mid] <= arr[start2])
      //{
      //  return;
      //}

      // Two pointers to maintain start
      // of both arrays to merge
      while (start <= mid && start2 <= end)
      {
        // If element 1 is in right place
        if (arr[start] <= arr[start2])
        {
          start++;
        }
        else
        {
          int value = arr[start2];
          int index = start2;

          // Shift all the elements between element 1
          // element 2, right by 1.
          while (index != start)
          {
            arr[index] = arr[index - 1];
            index--;
          }
          arr[start] = value;

          // Update all the pointers
          start++;
          mid++;
          start2++;
        }
      }
    }
    
    public void Sort(int[] arr, int l, int r)
    {
      if (l < r)
      {
        // Same as (l + r) / 2, but avoids overflow
        // for large l and r
        int m = l + (r - l) / 2;

        // Sort first and second halves
        Sort(arr, l, m);
        Sort(arr, m + 1, r);

        Merge(arr, l, m, r);
      }
    }
  }

}

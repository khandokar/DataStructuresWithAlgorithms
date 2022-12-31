using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
  public class QuickSelect
  {
    public int Select(int[] arr, int start, int stop, int k)
    {
      if (start > stop)
        return arr[start];

      int p = GetMedianIndex(arr, start, stop);
      Swap(arr, p, stop);

      int i = start;
      int j = stop - 1;

      while (i <= j)
      {
        while (i < stop && arr[i] < arr[stop]) i++;
        while (j >= start && arr[j] >= arr[stop]) j--;
        if (i < j)
        {
          Swap(arr, i, j);
          i++;
          j--;
        }
      }

      Swap(arr, i, stop); //swap with the bigger one only

      int sizeL = i - start;
      int sizeE = 1;
      int sizeG = stop - i;
      if (k > sizeL && k <= sizeL + sizeE)
      {
        return arr[i];
      }
      else if (k <= sizeL)
      {
        return Select(arr, start, i - 1, k);
      }
      else
      {
        return Select(arr, i + 1, stop, k - sizeL - sizeE);
      }
    }

    public static void Swap(int[] a, int i, int j)
    {
      int temp = a[i];
      a[i] = a[j];
      a[j] = temp;
    }

    public int GetMedianIndex(int[] arr, int start, int stop)
    {
      int x = arr[start];

      int m = (start + stop) / 2;
      int y = arr[m];

      int z = arr[stop];
      if ((x - y) * (z - x) >= 0) // x >= y and x <= z OR x <= y and x >= z
        return start;
      else if ((y - x) * (z - y) >= 0) // y >= x and y <= z OR y <= x and y >= z
        return m;
      else
        return stop;
    }

  }
}

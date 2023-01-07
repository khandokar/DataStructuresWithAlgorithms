using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
  public class RadixSort
  {
    public void Sort(int[] arr, int maxNumber, int radix)
    {
      List<int>[] bin = new List<int>[radix];
      for (int i = 0; i < radix; i++)
      {
        bin[i] = new List<int>();
      }
      int initial = 1;

      for (int a = 0; a < maxNumber.ToString().Length; a++)
      {
          for (int i = 0; i < arr.Length; i++)
          {
            int idx = (arr[i] / initial);
            idx = idx % radix;
            bin[idx].Add(arr[i]);
          }

          int index = 0;
          for (int i = 0; i < radix; i++)
          {
            for (int j = 0; j < bin[i].Count; j++)
            {
              arr[index++] = bin[i][j];
            }
            bin[i] = new List<int>();
          }
          initial = initial * radix;
         
      }
    }
  }
}

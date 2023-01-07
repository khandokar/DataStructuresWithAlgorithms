using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
  public class BucketSort
  { 
    public void Sort(int[] arr, int range)
    {
      if (range <= 0)
        return;

      int k = 11; //Number of Bucket
      int bRange = range / k;
      if (range % k > 0)
        bRange += 1;

      // 1) Create n empty buckets
      List<int>[] buckets = new List<int>[k];

      for (int i = 0; i < k; i++)
      {
        buckets[i] = new List<int>();
      }

      // 2) Put array elements in different buckets
      for (int i = 0; i < arr.Length; i++)
      {
        int idx = arr[i] / bRange;
        buckets[(int)idx].Add(arr[i]);
      }

      // 3) Sort individual buckets
      for (int i = 0; i < k; i++)
      {
        buckets[i].Sort();
      }

      // 4) Concatenate all buckets into arr[]
      int index = 0;
      for (int i = 0; i < k; i++)
      {
        for (int j = 0; j < buckets[i].Count; j++)
        {
          arr[index++] = buckets[i][j];
        }
      }
    }

    public void Sort(float[] arr, int range)
    {
      if (range <= 0)
        return;

      int k = 12; //Number of Bucket
    
      // 1) Create n empty buckets
      List<float>[] buckets = new List<float>[k];

      for (int i = 0; i < k; i++)
      {
        buckets[i] = new List<float>();
      }

      // 2) Put array elements in different buckets
      for (int i = 0; i < arr.Length; i++)
      {
        float idx = arr[i] * k;
        buckets[(int)idx].Add(arr[i]);
      }

      // 3) Sort individual buckets
      for (int i = 0; i < k; i++)
      {
        buckets[i].Sort();
      }

      // 4) Concatenate all buckets into arr[]
      int index = 0;
      for (int i = 0; i < k; i++)
      {
        for (int j = 0; j < buckets[i].Count; j++)
        {
          arr[index++] = buckets[i][j];
        }
      }

    }
  }
}

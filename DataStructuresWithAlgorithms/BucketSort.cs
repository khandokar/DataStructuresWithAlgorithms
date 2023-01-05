﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
  public class BucketSort
  {
    /*
     *  O(n + k)
     * 
     * 
     * 
     * 
     *
     *
    */
    public void Sort(float[] arr, int n)
    {
      if (n <= 0)
        return;

      // 1) Create n empty buckets
      List<float>[] buckets = new List<float>[n];

      for (int i = 0; i < n; i++)
      {
        buckets[i] = new List<float>();
      }

      // 2) Put array elements in different buckets
      for (int i = 0; i < arr.Length; i++)
      {
        float idx = arr[i];
        //float idx = arr[i] / n;
        //float idx = arr[i] * n;
        buckets[(int)idx].Add(arr[i]);
      }

      // 3) Sort individual buckets
      for (int i = 0; i < n; i++)
      {
        buckets[i].Sort();
      }

      // 4) Concatenate all buckets into arr[]
      int index = 0;
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < buckets[i].Count; j++)
        {
          arr[index++] = buckets[i][j];
        }
      }
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
  public class MyArray
  {
    public int FindKthLargest(int[] nums, int k)
    {
      PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

      foreach (int i in nums)
      {
        pq.Enqueue(i, i);
        if (pq.Count > k)
        {
          pq.Dequeue();
        }
      }

      return pq.Dequeue();
    }
  }
}

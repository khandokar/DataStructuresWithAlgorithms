using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
  public class BinarySearch
  {
    //Recursive Method (The recursive method follows the divide and conquer approach)
    //Binary Search is a searching algorithm used in a sorted array by repeatedly dividing the search interval in half.
    //The idea of binary search is to use the information that the array is sorted and reduce the time complexity to O(Log n). 
    public int Search(int[] arr, int l, int r, int x)
    {
      if (r >= l)
      {
        //int mid = l + (r - l) / 2;
        int mid = (l + r) / 2;

        // If the element is present at the
        // middle itself
        if (arr[mid] == x)
          return mid;

        // If element is smaller than mid, then
        // it can only be present in left subarray
        if (arr[mid] > x)
          return Search(arr, l, mid - 1, x);

        // Else the element can only be present
        // in right subarray
        return Search(arr, mid + 1, r, x);
      }

      // We reach here when element is not present
      // in array
      return -1;
    }

    public int FindMin(int[] nums)
    {
      int res = nums[0];
      int l = 0;
      int r = nums.Length - 1;

      while (l <= r)
      {
        if (nums[l] <= nums[r])
        {
          res = Math.Min(res, nums[l]);
          break;
        }

        int m = l + r / 2;
        if (nums[m] >= nums[l])
        {
          l = m + 1;
        }
        else
        {
          r = m - 1;
        }
      }
      return res;
    }
  }
}

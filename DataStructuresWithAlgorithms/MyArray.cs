using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

    public int LongestConsecutive(int[] nums)
    {
      HashSet<int> set = new HashSet<int>();
      foreach (int i in nums)
      {
        set.Add(i);
      }

      int longestSequenceLength = 0;

      for(int i = 0; i < nums.Length; i++)
      {
         int current_Num = nums[i];
         int current_sequence_length = 1;

        if (!set.Contains(current_Num - 1))
        {
          while (set.Contains(current_Num + 1))
          {
            current_Num++;
            current_sequence_length++;
          }

          longestSequenceLength = Math.Max(current_sequence_length, longestSequenceLength);
        }
      }

      return longestSequenceLength;
    }
 
    public string DecodeString(String str)
    {
      Stack<int> counts = new Stack<int>();
      Stack<String> result = new Stack<String>();
      int index = 0;
      int digit = 0;
      string res = string.Empty;
      while (index < str.Length)
      {
        digit = 0;
        if (Char.IsDigit(str,index))
        {
          while(Char.IsDigit(str, index))
          {
            digit = digit * 10 + Convert.ToInt32(str[index].ToString());
            index++;
          }
          counts.Push(digit); 
        }
        else if(str[index].Equals('['))
        {
          result.Push(res);
          res = string.Empty;
          index++;
        }
        else if(str[index].Equals(']'))
        {
          StringBuilder sb = new StringBuilder(result.Pop());
          int count = counts.Pop();
          for(int i = 0; i<count; i++)
          {
            sb.Append(res);
          }
          res = sb.ToString();
          index++;
        }
        else
        {
          res += str[index];
          index++;
        }
      }
      return res;
    }

    public int[] ProductExceptSelf(int[] nums)
    {
      int N = nums.Length;
      int[] result = new int[N];
      result[0] = 1;

      for(int i=1; i<N; i++)
      {
        result[i] = result[i-1] * nums[i-1];
      }

      int R = 1;
      for(int i = N - 1; i >= 0; i--)
      {
        result[i] = result[i] * R;
        R = R * nums[i];
      }

      return result;
    }

    public List<List<string>> GroupAnagrams(string[] str)
    {
      Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

      foreach(string s in str)
      {
        string key = GenerateKey(s);

        if(keyValuePairs.ContainsKey(key))
        {
          keyValuePairs[key].Add(s);
        }
        else
        {
          List<string> list = new List<string>();
          list.Add(s);
          keyValuePairs.Add(key, list);
        }
      }
      return keyValuePairs.Values.ToList();
    }

    private string GenerateKey(string str)
    {
      int[] map = new int[26];

      char[] chars = str.ToCharArray();

      foreach(char c in chars)
      {
        map[c - 'a']++;
      }

      StringBuilder stringBuilder = new StringBuilder();

      foreach(int num in map)
      {
        stringBuilder.Append(num);
        stringBuilder.Append("#");
      }

      return stringBuilder.ToString();
    }

    private string GenerateKey1(string str)
    {
      char[]  arr = str.ToCharArray();
      Array.Sort(arr);
      return new string(arr);
    }
  }
}

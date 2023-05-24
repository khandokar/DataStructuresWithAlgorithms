using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
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

            for (int i = 0; i < nums.Length; i++)
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
                if (Char.IsDigit(str, index))
                {
                    while (Char.IsDigit(str, index))
                    {
                        digit = digit * 10 + Convert.ToInt32(str[index].ToString());
                        index++;
                    }
                    counts.Push(digit);
                }
                else if (str[index].Equals('['))
                {
                    result.Push(res);
                    res = string.Empty;
                    index++;
                }
                else if (str[index].Equals(']'))
                {
                    StringBuilder sb = new StringBuilder(result.Pop());
                    int count = counts.Pop();
                    for (int i = 0; i < count; i++)
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

            for (int i = 1; i < N; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            int R = 1;
            for (int i = N - 1; i >= 0; i--)
            {
                result[i] = result[i] * R;
                R = R * nums[i];
            }

            return result;
        }

        public bool ContainsDuplicate(int[] nums)
        {

            //Array.Sort(nums);

            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    if (nums[i] == nums[i + 1])
            //    {
            //        return true;
            //    }
            //}

            //return false;

            HashSet<int> visited = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited.Contains(nums[i]))
                    return true;
                visited.Add(nums[i]);
            }

            return false;
        }

        public bool IsAnagram(string s, string t)
        {
            //O(s+t), O(s+t)

            //if (s.Length != t.Length) return false;
            //int[] ints= new int[26];
            //for (int i = 0; i < s.Length; i++)
            //{
            //  ints[s[i] - 'a']++;
            //  ints[t[i] - 'a']--;
            //}

            //for(int i = 0; i < ints.Length;i++)
            //{
            //  if (ints[i] != 0)
            //  {
            //    return false;
            //  }
            //}
            //return true;

            //What if the inputs contain Unicode characters? How would you adapt your solution to such a case?

            if (s.Length != t.Length) return false;

            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            Dictionary<char, int> dic2 = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic1.ContainsKey(s[i]))
                {
                    dic1[s[i]]++;
                }
                else
                {
                    dic1.Add(s[i], 1);
                }

                if (dic2.ContainsKey(t[i]))
                {
                    dic2[t[i]]++;
                }
                else
                {
                    dic2.Add(t[i], 1);
                }
            }

            foreach (KeyValuePair<char, int> c in dic1)
            {
                if (c.Value != dic2[c.Key])
                {
                    return false; 
                }
            }
            return true;
        }

        /// <summary>
        /// Time complexity is O(n).
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int[] TwoSum(int[] nums, int target)
        {
            /*
             * Time complexity is O(n^2)
             * Time consuming for large array
              for (int i = 0; i < nums.Length; i++)
              {
                int complement = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                  if (nums[j] == target)
                  {
                    return new int[] { i, j };
                  }
                }
              }
              throw new Exception("No Found");
            */

            Dictionary<int, int> result = new Dictionary<int, int>(); 
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsValue(target - nums[i]))
                {
                    KeyValuePair<int, int> element = result.First(v => v.Value == target - nums[i]);

                    return new int[] { element.Key, i };
                }
                result.Add(i, nums[i]);
            }
            throw new Exception("No Found");
        }

        /// <summary>
        /// Time Complexity is O(n)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public List<List<string>> GroupAnagrams(string[] str)
        {
            Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

            foreach (string s in str)
            {
                string key = GenerateKey(s);

                if (keyValuePairs.ContainsKey(key))
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

        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> freqMap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
            }

            PriorityQueue<int, int> heap = new PriorityQueue<int, int>(
                Comparer<int>.Create((x, y) => x - y)
            );
            foreach (var freqEntry in freqMap)
            {
                heap.Enqueue(freqEntry.Key, freqEntry.Value);
                if (heap.Count > k)
                    heap.Dequeue();
            }

            int[] result = new int[k];
            for (int i = k - 1; i >= 0; i--)
            {
                result[i] = heap.Dequeue();
            }

            return result;
        }

        public IList<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> triplets = new List<List<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        triplets.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        j++;

                        if (j < k && nums[j] == nums[j - 1])
                        {
                            j++;
                        }
                    }
                    else if (nums[i] + nums[j] + nums[k] < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }

            return triplets;
        }

        public int MaxArea(int[] height)
        {
            int initialPointer = 0;
            int lastPointer = height.Length - 1;
            int maxArea = 0;
            while (initialPointer < lastPointer)
            {
                if (height[initialPointer] < height[lastPointer])
                {
                    maxArea = Math.Max(maxArea, (lastPointer - initialPointer) * height[initialPointer]);
                    initialPointer++;
                }
                else
                {
                    maxArea = Math.Max(maxArea, (lastPointer - initialPointer) * height[lastPointer]);
                    lastPointer--;
                }
            }

            return maxArea;
        }

        public bool IsPalindrome(string s)
        {
            string newString = string.Empty;
            foreach (char c in s)
            {
                if (char.IsLetter(c) || char.IsNumber(c))
                {
                    newString += char.ToLower(c);
                }
            }

            int initialPointer = 0;
            int lastPointer = newString.Length - 1;

            while (initialPointer <= lastPointer)
            {
                if (newString[initialPointer] != newString[lastPointer])
                {
                    return false;
                }
                initialPointer++;
                lastPointer--;
            }

            return true;
        }

        /// <summary>
        /// Time Complexity O(n).
        /// Sliding Window
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int min_price = int.MaxValue;
            int max_profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min_price)
                {
                    min_price = prices[i];
                }
                else if (prices[i] - min_price > max_profit)
                {
                    max_profit = prices[i] - min_price;
                }
            }

            return max_profit;
        }

        public int LengthOfLongestSubstring(string s)
        {
            HashSet<string> set = new HashSet<string>();
            int a_pointer = 0;
            int b_pointer = 0;
            int max = 0;
            while (b_pointer < s.Length)
            {
                if (!set.Contains(s[b_pointer].ToString()))
                {
                    set.Add(s[b_pointer].ToString());
                    max = Math.Max(max, set.Count);
                    b_pointer++;
                }
                else
                {
                    set.Remove(s[a_pointer].ToString());
                    a_pointer++;
                }
            }
            return max;
        }

        public int CharacterReplacement(string s, int k)
        {
            int N = s.Length;
            int[] char_counts = new int[26];

            int window_start = 0;
            int max_length = 0;
            int max_count = 0;

            for (int window_end = 0; window_end < N; window_end++)
            {
                char_counts[s[window_end] - 'A']++;
                int current_char_count = char_counts[s[window_end] - 'A'];
                max_count = Math.Max(max_count, current_char_count);

                while (window_end - window_start - max_count + 1 > k)
                {
                    char_counts[s[window_start] - 'A']--;
                    window_start++;
                }

                max_length = Math.Max(max_length, window_end - window_start + 1);
            }
            return max_length;
        }

        public string MinWindow(string s, string t)
        {
            if (t.Length > s.Length || s.Length < 1) return string.Empty;

            string mwStr = string.Empty;
            int mLength = int.MaxValue;
            int startIndex = 0;
            int endIndex = 0;

            int window_start = 0;

            int need = t.Length;
            int have = 0;

            Dictionary<char, int> window = new Dictionary<char, int>();
            Dictionary<char, int> tT = new Dictionary<char, int>();

            foreach (char c in t)
            {
                tT.Add(c, 1);
            }

            for (int window_end = 0; window_end < s.Length; window_end++)
            {
                char c = s[window_end];
                if (window.ContainsKey(c))
                {
                    window[c] = window[c] + 1;
                }
                else
                {
                    window.Add(c, 1);
                }

                if (tT.ContainsKey(c) && window[c] == tT[c])
                {
                    have++;
                }

                while (have == need)
                {
                    //Update our Result 
                    if (window_end - window_start + 1 < mLength)
                    {
                        startIndex = window_start;
                        endIndex = window_end;
                        mLength = window_end - window_start + 1;
                    }

                    //Pop from the left of our window
                    window[s[window_start]]--;
                    if (tT.ContainsKey(s[window_start]) && window[s[window_start]] < tT[s[window_start]])
                    {
                        have--;
                    }
                    window_start++;
                }
            }

            mwStr = mLength < int.MaxValue ? s.Substring(startIndex, endIndex - startIndex + 1) : string.Empty;

            return mwStr;
        }

        private string GenerateKey(string str)
        {
            /*
             * Complexity is O(n*klogk)
             *  n - Number of element in Str array
             *  k - Number of character in a single string
             *  Array.Sort uses Merge/Quicksort so so it takes O(klogk) 
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
            */

            int[] map = new int[26];

            char[] chars = str.ToCharArray();

            foreach (char c in chars)
            {
                map[c - 'a']++;
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (int num in map)
            {
                stringBuilder.Append(num);
                stringBuilder.Append("#");
            }

            return stringBuilder.ToString();
        }

    }
}

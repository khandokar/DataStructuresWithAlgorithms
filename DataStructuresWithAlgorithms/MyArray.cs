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

        //Two Sum II - Input Array Is Sorted
        public int[] TwoSumInSortedArray(int[] numbers, int target)
        {
            int firstIndex = 0;
            int lastIndex = numbers.Length - 1;

            while(firstIndex < lastIndex)
            {
                if (numbers[firstIndex] + numbers[lastIndex] > target)
                {
                    lastIndex--;
                }
                else if(numbers[firstIndex] + numbers[lastIndex] < target)
                {
                    firstIndex++;
                }
                else
                {
                    return new int[] { firstIndex + 1, lastIndex + 1 };
                }
            }
            return new int[0];
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

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();

            int left, right;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                //Igo
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                left = i + 1;
                right = nums.Length - 1;

                while (left < right)
                {
                    if (nums[i] + nums[left] + nums[right] > 0)
                    {
                        right--;
                    }
                    else if (nums[i] + nums[left] + nums[right] < 0)
                    {
                        left++;
                    }
                    else
                    {
                        res.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        while (nums[left] == nums[left - 1] && left < right)
                        {
                            left++;
                        }
                    }
                }
            }
            return res;
        }

        public int MaxArea(int[] height)
        {
            int res = 0, area = 0, left = 0, right = height.Length - 1;

            while (left < right)
            {

                area = (Math.Min(height[left], height[right])) * (right - left);
                res = Math.Max(area, res);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }

            }
            return res;
        }

        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                else
                {
                    if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
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
            int maxProfit = 0;
            int minPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                int currPrice = prices[i];
                minPrice = Math.Min(minPrice, currPrice);
                maxProfit = Math.Max(maxProfit, currPrice - minPrice);
            }
            return maxProfit;
        }

        //https://leetcode.com/problems/longest-string-chain/
        public int LongestStrChain(string[] words)
        {
            if (words.Length <= 1)
                return words.Length;

            int strLength = 1;

            bool found = false;

            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            foreach (string word in words)
            {
                found = false;
                for (int i = 0; i < word.Length; i++)
                {
                    var partWord = word.Remove(i, 1);

                    if (keyValuePairs.TryGetValue(partWord, out int value))
                    {
                        keyValuePairs.Add(word, value + 1);
                        strLength = Math.Max(strLength, value + 1);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    keyValuePairs.Add(word, 1);
                }
            }

            return strLength;
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
            int left = 0, maxLength = 0;
            int mostFrequentLetterCount = 0; // Count of most frequent letter in the window
            int[] charCounts = new int[26]; // Counts per letter

            for (int right = 0; right < s.Length; right++)
            {
                charCounts[s[right] - 'A']++;
                mostFrequentLetterCount = Math.Max(mostFrequentLetterCount, charCounts[s[right] - 'A']);

                int lettersToChange = (right - left + 1) - mostFrequentLetterCount;
                if (lettersToChange > k)
                { // Window is invalid, decrease char count and move left pointer
                    charCounts[s[left] - 'A']--;
                    left++;
                }

                maxLength = Math.Max(maxLength, (right - left + 1));
            }
            return maxLength;
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

using System.Collections.Generic;
using System.Text;
using System;
using System.Linq;
using static DataStructuresWithAlgorithms.MySingleLinkedList;
using System.Security.Cryptography.X509Certificates;

namespace DataStructuresWithAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myNum = { 10, 7, 1, 8, 5, 6, 3, 9, 8, 2 };

            //Quicksort quicksort = new Quicksort();
            //quicksort.Sort(myNum, 0, 9);

            //foreach(int a in myNum)
            //Console.Write(a +" ");


            //int[] arr = { 500, 2, 9, 100, 3, 8, 6, 700 };
            //int arr_size = arr.Length;

            //Mergesort mergesort = new Mergesort();
            //mergesort.Sort(arr, 0, arr_size - 1);

            //foreach(int a in arr)
            //Console.Write(a +" ");

            //MySingleLinkedList msllist = new MySingleLinkedList();
            //msllist.Insert(3);
            //msllist.Insert(2);
            //msllist.Insert(0);
            //msllist.Insert(-4);
            //msllist.MakeCycle(1);
            //bool hasCycle = msllist.HasCycle();
            //Node node = msllist.DetectCycle();
            //Console.WriteLine(node == null ? "" : node.data);

            //msllist.Insert(1);
            //bool hasCycle = msllist.HasCycle();
            //Console.WriteLine(hasCycle);
            //Node node = msllist.DetectCycle();
            //Console.WriteLine(node == null ? "" : node.data);

            //msllist.Insert(1);
            //msllist.Insert(2);
            //msllist.MakeCycle(0);
            //bool hasCycle = msllist.HasCycle();
            //Node node = msllist.DetectCycle();


            //MySingleLinkedList msllist = new MySingleLinkedList();
            //msllist.Insert(2);
            //msllist.Insert(2);
            //msllist.Insert(2);
            //msllist.Insert(3);
            //msllist.Insert(4);
            //msllist.DeleteDuplicates2();
            //msllist.Show();

            //MySingleLinkedList msllist1 = new MySingleLinkedList();
            //msllist1.Insert(2);
            //msllist1.Insert(4);
            //msllist1.Insert(3);

            //MySingleLinkedList msllist2 = new MySingleLinkedList();
            //msllist2.Insert(5);
            //msllist2.Insert(6);
            //msllist2.Insert(4);

            //MySingleLinkedList msllist1 = new MySingleLinkedList();
            //msllist1.Insert(9);
            //msllist1.Insert(9);
            //msllist1.Insert(9);
            //msllist1.Insert(9);
            //msllist1.Insert(9);
            //msllist1.Insert(9);
            //msllist1.Insert(9);

            //MySingleLinkedList msllist2 = new MySingleLinkedList();
            //msllist2.Insert(9);
            //msllist2.Insert(9);
            //msllist2.Insert(9);
            //msllist2.Insert(9);

            //MySingleLinkedList msllist1 = new MySingleLinkedList();
            //msllist1.Insert(0);

            //MySingleLinkedList msllist2 = new MySingleLinkedList();
            //msllist2.Insert(0);

            //msllist.AddTwoNumbers(msllist1.Head, msllist2.Head);
            //msllist.Show();


            ///*https://leetcode.com/problems/remove-nth-node-from-end-of-list/

            //MySingleLinkedList msllist2 = new MySingleLinkedList();
            //msllist2.Insert(1);
            //msllist2.Insert(2);
            //msllist2.Insert(3);
            //msllist2.Insert(4);
            //msllist2.Insert(5);

            //msllist2.RemoveNthFromEnd(2);
            //msllist2.Show();

            //msllist2 = new MySingleLinkedList();
            //msllist2.Insert(1);
            //msllist2.Insert(2);

            //msllist2.RemoveNthFromEnd(1);
            //msllist2.Show();
            //*/

            ///*
            //https://leetcode.com/problems/reverse-linked-list/

            //MySingleLinkedList msllist2 = new MySingleLinkedList();
            //msllist2.Insert(1);
            //msllist2.Insert(2);
            //msllist2.Insert(3);
            //msllist2.Insert(4);
            //msllist2.Insert(5);


            //msllist2.ReverseList();
            //msllist2.Show();

            //msllist2 = new MySingleLinkedList();
            //msllist2.Insert(1);
            //msllist2.Insert(2);

            //msllist2.ReverseList();
            //msllist2.Show();

            //*/

            ///*
            //https://leetcode.com/problems/merge-two-sorted-lists/
            //MySingleLinkedList msllist1 = new MySingleLinkedList();
            //msllist1.Insert(1);
            //msllist1.Insert(2);
            //msllist1.Insert(4);

            //MySingleLinkedList msllist2 = new MySingleLinkedList();
            //msllist2.Insert(1);
            //msllist2.Insert(3);
            //msllist2.Insert(4);

            //MySingleLinkedList msllist = new MySingleLinkedList();
            //msllist.MergeTwoLists(msllist1.Head, msllist2.Head);
            //msllist2.Show();
            // */

            //*
            //MySingleLinkedList msllist = new MySingleLinkedList();
            //msllist.Insert(1);
            //msllist.Insert(2);
            //msllist.Insert(3);
            //msllist.Insert(4);
            //msllist.Insert(5);

            //msllist.ReorderList();
            //msllist.Show();

            //*/

            /*

            https://leetcode.com/problems/merge-k-sorted-lists/
            MySingleLinkedList msllist1 = new MySingleLinkedList();
            msllist1.Insert(1);
            msllist1.Insert(4);
            msllist1.Insert(5);

            MySingleLinkedList msllist2 = new MySingleLinkedList();
            msllist2.Insert(1);
            msllist2.Insert(3);
            msllist2.Insert(4);

            MySingleLinkedList msllist3 = new MySingleLinkedList();
            msllist3.Insert(2);
            msllist3.Insert(6);

            MySingleLinkedList msllist = new MySingleLinkedList();
            msllist.MergeKListsMerge(new Node[] { msllist1.Head, msllist2.Head, msllist3.Head});
            msllist.Show();

            */

            /*
            https://leetcode.com/problems/kth-largest-element-in-an-array/

            MyArray marray = new MyArray();

            int[] mArray = new int[] { 1, 5, 6, 9, 2 };

            int num = marray.FindKthLargest(mArray, 3);

            QuickSelect qs = new QuickSelect();

            num = qs.Select(mArray, 0, 4, 3);

            */


            //int[] mynum = new int[] { 100, 4, 200, 1, 3, 2 };
            //int[] mynum = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
            //MyArray marray = new MyArray();
            //int conNumb = marray.LongestConsecutive(mynum);

            //MyArray marray = new MyArray();
            //string s = "3[a]2[bc]";
            //s = "3[a2[c]]";   
            //string result = marray.DecodeString(s);

            //int[] mynum = new int[] { 1,2,3,4 };
            //mynum = new int[] { -1, 1, 0, -3, 3 };
            //MyArray marray = new MyArray();
            //int[] my = marray.ProductExceptSelf(mynum);

            //string[] s = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            //var dd = marray.GroupAnagrams(s);

            //foreach(var a in dd)
            //{
            //  Console.WriteLine(a.ToString());
            //}

            // MyArray marray = new MyArray();
            //int[] mynum = new int[] { 2, 7, 11, 15 };
            //int target = 9;
            //int[] result = marray.TwoSum(mynum, target);

            //int[] mynum = new int[] { 2, 3, 4 };
            //int target = 6;

            //int[] result = marray.TwoSumInSortedArray(mynum, target);


            //MyArray marray = new MyArray();
            //string s = "anagram", t = "nagaram";

            //bool b = marray.IsAnagram(s, t);

            // MyArray marray = new MyArray();
            //int[] nums = new int[] { 1, 2, 3, 1 };
            //int[] nums = new int[] { 1, 2, 3, 4 };

            //bool resutl = marray.ContainsDuplicate(nums);

            //int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            //int[] d = marray.TopKFrequent(nums, 2);

            //int[] nums = new int[] { 1, 2, 3, 4 };

            //int[] array = marray.ProductExceptSelf(nums);

            //int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };
            //int result = marray.LongestConsecutive(nums);

            /*

            BucketSort bucketSort = new BucketSort();

            float[] arr = { (float)0.897, (float)0.565, (float)0.656, (float)0.1234, (float)0.665, (float)0.3434 };

            bucketSort.Sort(arr, 10);

            float[] arr1 = { (float).2, (float)1.2f, (float)3.2f, (float)7.4f, (float)2.3f, (float)5.6f, (float)8.3f, (float)4.7f, (float)6.3f, (float)7.2f, (float)1.1f, (float)40.2f, (float)50.1f, (float)39.1f };

            bucketSort.Sort(arr1, 51);

            int[] arr2 = { 10, 12, 20, 501, 101, 500, 25, 25, 26 };

            bucketSort.Sort(arr2, 501);

            */

            /*
            RadixSort radixSort = new RadixSort();
            //int[] arr = { 4982, 325, 5631, 8962, 5362, 5341, 7282};
            //int[] arr = { 48, 1, 6 ,23, 37, 19, 21 };
            int[] arr = {300, 215, 110, 115, 210, 315, 310, 200, 100 };
            radixSort.Sort(arr, 8962, 10);
            */

            /*
            MyArray marray = new MyArray();
            int[] arry = { -1, 0, 1, 2, -1, -4 };
            //int[] arry = { 0, 1, 1 };
            //int[] arry = { 0, 0, 0 };
            IList<IList<int>> ints = marray.ThreeSum(arry);
            foreach(var v in ints)
            {
              Console.Write("[");
              foreach(var p in v)
              {
                Console.Write(p.ToString());
                Console.Write(" ");
              }
              Console.Write("] ");
            }
            /*

            /*
            MyArray marray = new MyArray();
            //int[] arry = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] arry = { 1, 1 };
            int maxArea = marray.MaxArea(arry);
            Console.Write(maxArea.ToString());
            */


            //MyArray marray = new MyArray();
            //String s = "A man, a plan, a canal: Panama";
            //String s = "race a car";
            //String s = " ";
            //bool isPalindrome = marray.IsPalindrome(s);
            //Console.Write(isPalindrome);



            //* https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
            //* Sliding Window
            //MyArray marray = new MyArray();
            //int[] arry = { 7, 1, 5, 3, 6, 4 };
            //int[] arry = { 7, 6, 4, 3, 1 };
            //int maxProfit = marray.MaxProfit(arry);
            //Console.WriteLine(maxProfit);



            //* https://leetcode.com/problems/longest-substring-without-repeating-characters/
            //* Sliding Window
            //MyArray marray = new MyArray();
            //String s = "abcabcbb";
            //String s = "bbbbb";
            //String s = "pwwkew";
            //int length = marray.LengthOfLongestSubstring(s);
            //Console.WriteLine(length);




            // https://leetcode.com/problems/longest-repeating-character-replacement/
            //MyArray marray = new MyArray();
            //string s = "ABAB";
            //int k = 2;
            //string s = "AABABBA";
            //int k = 2;
            //int length = marray.CharacterReplacement(s,k);
            //Console.WriteLine(length);


            /*
             * https://leetcode.com/problems/minimum-window-substring/
            MyArray marray = new MyArray();
            string s = "ADOBECODEBANC";
            string t = "ABC";
            //string s = "a";
            //string t = "aa";
            string min = marray.MinWindow(s, t);
            Console.WriteLine(min);
            */


            // * https://leetcode.com/problems/valid-parentheses/
            // * 20. Valid Parentheses
            //MyString mystring = new MyString();
            //string ss = "({[]})";
            //string s = "]{[]})";
            //string s = "((";
            //bool valid = mystring.IsValid(s);



            /*
             * https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
             * 153. Find Minimum in Rotated Sorted Array
            BinarySearch bs = new BinarySearch();
            int[] arr = { 2, 3, 4, 10, 40, 50, 51, 65};
            int n = arr.Length;
            int x = 10;
            int position =  bs.Search(arr, 0, n, x);

            int[] nums = { 3, 4, 5, 1, 2 };
            int min = bs.FindMin(nums);

            int[] nums1 = { 6, 7, 0, 1, 2, 3, 4, 5 };
            min = bs.FindMin(nums1);

            int[] nums2 = { 4, 5, 6, 7, 0, 1, 2 };
            min = bs.FindMin(nums2);

            int[] nums3 = { 11, 13, 15, 17 };
            min = bs.FindMin(nums3);
            */

            /*
             * https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
             * 
            BinarySearch bs = new BinarySearch();
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 3;
            int position = bs.Search(nums, target);
            */

            /*
             * 226. Invert Binary Tree
             * https://leetcode.com/problems/invert-binary-tree/
            MyBinarySearchTree bst = new MyBinarySearchTree();
            bst.Insert(4);
            bst.Insert(2); 
            bst.Insert(7);
            bst.Insert(1);
            bst.Insert(3);
            bst.Insert(6);
            bst.Insert(9);
            //bst.PrintTree();

            BinaryNode b = bst.InvertTree(bst.Root);
            bst.PrintTree();
            */


            /*
             * 104. Maximum Depth of Binary Tree
             * https://leetcode.com/problems/maximum-depth-of-binary-tree/
            MyBinaryTree bst = new MyBinaryTree();
            bst.Insert(3);
            bst.Insert(9);
            bst.Insert(20);
            bst.Insert(null);
            bst.Insert(null);
            bst.Insert(15);
            bst.Insert(7);
            int depth = bst.MaxDepth(bst.Root);
            depth = bst.MaxDepthBFS(bst.Root);
            depth = bst.MaxDepthDFS(bst.Root);
            */


            /*
            * 100.Same Tree
            * https://leetcode.com/problems/same-tree/
            MyBinaryTree bst1 = new MyBinaryTree();
            bst1.Insert(1);
            bst1.Insert(2);
            bst1.Insert(3);
            MyBinaryTree bst2 = new MyBinaryTree();
            bst2.Insert(1);
            bst2.Insert(2);
            bst2.Insert(5);

            bool result = bst1.IsSameTree(bst1.Root, bst2.Root);
            */

            /*
             * 572. Subtree of Another Tree
             * https://leetcode.com/problems/subtree-of-another-tree/
            MyBinaryTree bst1 = new MyBinaryTree();
            bst1.Insert(3);
            bst1.Insert(4);
            bst1.Insert(5);
            bst1.Insert(1);
            bst1.Insert(2);
            bst1.Insert(null);
            bst1.Insert(null);
            bst1.Insert(null);
            bst1.Insert(null);
            bst1.Insert(0);

            MyBinaryTree bst2 = new MyBinaryTree();
            bst2.Insert(4);
            bst2.Insert(1);
            bst2.Insert(2);
            bool result = bst1.IsSubtree(bst1.Root, bst2.Root);
            */

            /*
             * 235. Lowest Common Ancestor of a Binary Search Tree
             * https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
             * Time Complexity-O(logn), Space Complexity - O(1)
            MyBinarySearchTree bst = new MyBinarySearchTree();
            bst.Insert(6);
            bst.Insert(2);
            bst.Insert(8);
            bst.Insert(0);
            bst.Insert(4);
            bst.Insert(7);
            bst.Insert(9);
            bst.Insert(null);
            bst.Insert(null);
            bst.Insert(3);
            bst.Insert(5);
            TreeNode t1 = bst.LowestCommonAncestor(bst.Root, new TreeNode(2), new TreeNode(4));
            TreeNode t2 = bst.LowestCommonAncestor(bst.Root, new TreeNode(2), new TreeNode(4));

            bst.Insert(2);
            bst.Insert(1);
            TreeNode t3 = bst.LowestCommonAncestor(bst.Root, new TreeNode(2), new TreeNode(1));
            */

            /*
             * 102. Binary Tree Level Order Traversal 
             * https://leetcode.com/problems/binary-tree-level-order-traversal/
            MyBinaryTree bst1 = new MyBinaryTree();
            bst1.Insert(3);
            bst1.Insert(9);
            bst1.Insert(20);
            bst1.Insert(null);
            bst1.Insert(null);
            bst1.Insert(15);
            bst1.Insert(7);
            IList<IList<int>> t1 = bst.LevelOrder(bst1.Root);

            MyBinaryTree bst1 = new MyBinaryTree();
            bst1.Insert(1);
            IList<IList<int>> t1 = bst1.LevelOrder(bst1.Root);
            */

            /*
             * https://leetcode.com/problems/validate-binary-search-tree/
             * 98. Validate Binary Search Tree
            MyBinarySearchTree bst1 = new MyBinarySearchTree();
            bst1.Insert(5);
            bst1.Root.Left = new TreeNode(3);
            bst1.Root.Right = new TreeNode(7);
            //bst1.Root.Left.Left= new TreeNode(null);
            //bst1.Root.Left.Right = new TreeNode(null);
            bst1.Root.Right.Left = new TreeNode(4);
            bst1.Root.Right.Right = new TreeNode(8);
            bool isValid = bst1.IsValidBST(bst1.Root);
            */

            /*
             * https://leetcode.com/problems/validate-binary-search-tree/
             * 98. Validate Binary Search Tree
            MyBinarySearchTree bst1 = new MyBinarySearchTree();
            bst1.Insert(5);
            bst1.Root.Left = new TreeNode(3);
            bst1.Root.Right = new TreeNode(7);
            //bst1.Root.Left.Left= new TreeNode(null);
            //bst1.Root.Left.Right = new TreeNode(null);
            bst1.Root.Right.Left = new TreeNode(4);
            bst1.Root.Right.Right = new TreeNode(8);
            bool isValid = bst1.IsValidBST(bst1.Root);
            */

            //MyBinarySearchTree bst1 = new MyBinarySearchTree();
            //bst1.Insert(5);
            //bst1.Insert(3);
            //bst1.Insert(6);
            //bst1.Insert(2);
            //bst1.Insert(4);
            ////bst1.Insert(null);
            ////bst1.Insert(null);
            //bst1.Insert(1);
            //int value = bst1.KthSmallest(bst1.Root,3);

            /*
            MyBinarySearchTree bst1 = new MyBinarySearchTree();
            bst1.Insert(25);
            bst1.Insert(15);
            bst1.Insert(50);
            bst1.Insert(10);
            bst1.Insert(22);
            bst1.Insert(35);
            bst1.Insert(70);
            bst1.Insert(4);
            bst1.Insert(12);
            bst1.Insert(18);
            bst1.Insert(24);
            bst1.Insert(31);
            bst1.Insert(44);
            bst1.Insert(66);
            bst1.Insert(90);
            //bst1.PrintTreeInOrderUsingRecusive();
            //bst1.PrintTreeInOrderWithoutRecusion();
            //bst1.PrintTreePreOrderUsingRecusive();
            //bst1.PrintTreePreOrderWithoutRecusion();
            //bst1.PrintTreePostOrderUsingRecursion();
            bst1.PrintTreePostOrderWithoutRecursion();
            */

            //MyBinaryTree bt1 = new MyBinaryTree();

            //int[] preorder = { 3, 9, 20, 15, 7 };
            //int[] inorder = { 9, 3, 15, 20, 7 };

            //TreeNode t = bt1.BuildTree(preorder, inorder);

            //MyBinaryTree bt1 = new MyBinaryTree();
            //bt1.Insert(-10);
            //bt1.Root.Left = new TreeNode(9);
            //bt1.Root.Right = new TreeNode(20);
            //bt1.Root.Right.Left = new TreeNode(15);
            //bt1.Root.Right.Right = new TreeNode(7);

            //int max = bt1.MaxPathSum(bt1.Root);

            //MyBinaryTree bt1 = new MyBinaryTree();
            //bt1.Insert(1);
            //bt1.Root.Left = new TreeNode(2);
            //bt1.Root.Right = new TreeNode(3);
            //bt1.Root.Right.Left = new TreeNode(4);
            //bt1.Root.Right.Right = new TreeNode(5);
            //string hola = bt1.Serialize(bt1.Root);
            //TreeNode t = bt1.Deserialize(hola);

            //Trie t = new Trie();
            //t.Insert("apple");
            //t.Insert("le");

            //bool exist = t.Search("le");

            //bool exist1 = t.StartsWith("lep");

            //WordDictionary wd = new WordDictionary();
            // wd.AddWord("bad");
            // bool exist = wd.Search(".ad");

            // Create the link list.

            //MySingleLinkedList msllist = new MySingleLinkedList();
            //msllist.Insert(3);
            //msllist.Insert(2);
            //msllist.Insert(0);
            //msllist.Insert(-4);
            //msllist.MakeCycle(1);

            //MySingleLinkedList msllist = new MySingleLinkedList();
            //msllist.Insert(1);
            //msllist.Insert(2);
            //msllist.MakeCycle(0);

            //bool b = HasCycle(msllist.Head);

            //string[] arr = new string[] { "xbc", "pcxbcf", "xb", "cxbc", "pcxbc" };

            //string[] arr = new string[] { "a", "b", "ba", "bca", "bda", "bdca" };

            //string[] arr = new string[] { "abcd", "dbqca" };

            //LongestStrChain(arr);

            //int[] a = new int[] { 1, 3, 4, 2, 2 };
            //floydAlgorithm(a);

            //Trie trie = new Trie();
            //trie.Insert("and");
            //trie.Insert("ant");

            //trie.Insert("dog");
            //trie.Search("dog");    // return true
            //trie.Search("do");     // return false
            //trie.StartsWith("do"); // return true
            //trie.Insert("do");
            //trie.Search("do");     // return true

            // Create an example Trie
            //Trie2 trie2 = new Trie2();
            //TrieNode2 root = new TrieNode2();
            //List<string> arr = new List<string> { "and", "ant", "do", "geek", "dad", "ball" };
            //List<string> arr = new List<string> { "and", "andt" };
            //foreach (string s in arr)
            //{
            //    trie2.InsertKey(root, s);
            //}

            //// One by one search strings
            //List<string> searchKeys =
            //     new List<string> { "do", "gee", "bat" };
            //foreach (string s in searchKeys)
            //{
            //    Console.WriteLine("Key : " + s);
            //    if (trie2.SearchKey(root, s))
            //        Console.WriteLine("Present");
            //    else
            //        Console.WriteLine("Not Present");
            //}

            Console.ReadLine();
        }

        //private static int floydAlgorithm(int[] nums)
        //{
        //    int slow = 0, fast = 0;

        //    while (true)
        //    {
        //        slow = nums[slow];
        //        fast = nums[nums[fast]];
        //        if (slow == fast)
        //            break;
        //    }

        //    var slow2 = 0;

        //    while (true)
        //    {
        //        slow = nums[slow];
        //        slow2 = nums[slow2];
        //        if (slow == slow2)
        //            return slow;
        //    }

        //    return 0;
        //}

    }

}

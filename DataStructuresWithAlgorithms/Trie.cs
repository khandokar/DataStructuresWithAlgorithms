using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
    /// <summary>
    /// https://neetcode.io/problems/implement-prefix-tree
    /// https://www.youtube.com/watch?v=oobqoCJlHA0
    /// </summary>
    public class Trie
    {
        private TrieNode root;
        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode curNode = root;
            char[] arr = word.ToCharArray();
            foreach(char currentChar in arr)
            {
                if(!curNode.Childrean.ContainsKey(currentChar))
                {
                    curNode.Childrean.Add(currentChar, new TrieNode());
                }
                curNode = curNode.Childrean[currentChar];
            }
            curNode.IsWord = true;
        }

        public bool Search(string word)
        {
            TrieNode curNode = root;
            char[] arr = word.ToCharArray();
            foreach (char currentChar in arr)
            {
                if (!curNode.Childrean.ContainsKey(currentChar))
                {
                    return false;
                }
                curNode = curNode.Childrean[currentChar];
            }
            return curNode.IsWord;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode curNode = root;
            char[] arr = prefix.ToCharArray();
            foreach (char currentChar in arr)
            {
                if (!curNode.Childrean.ContainsKey(currentChar))
                {
                    return false;
                }
                curNode = curNode.Childrean[currentChar];
            }
            return true;
        }
    }
}

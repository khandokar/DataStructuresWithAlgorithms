using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
    public class TrieNode3
    {
        public TrieNode3[] children = new TrieNode3[26];
        public int idx = -1;
        public int refs = 0;

        public void AddWord(string word, int i)
        {
            TrieNode3 cur = this;
            cur.refs++;
            foreach (char c in word)
            {
                int index = c - 'a';
                if (cur.children[index] == null)
                {
                    cur.children[index] = new TrieNode3();
                }
                cur = cur.children[index];
                cur.refs++;
            }
            cur.idx = i;
        }
    }
}

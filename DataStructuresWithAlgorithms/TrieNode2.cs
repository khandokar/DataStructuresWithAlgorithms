using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
    public class TrieNode2
    {
        public TrieNode2[] Child = new TrieNode2[26];
        public bool WordEnd = false;
    }
}

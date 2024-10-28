using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
    /// <summary>
    /// https://www.geeksforgeeks.org/trie-insert-and-search/
    /// https://www.geeksforgeeks.org/advantages-trie-data-structure/
    /// </summary>
    public class Trie2
    {

        public void InsertKey(TrieNode2 root, string key)
        {
            // Initialize the curr pointer with the root node
            TrieNode2 curr = root;

            // Iterate across the length of the string
            foreach (char c in key)
            {
                // Check if the node exists for the current
                // character in the Trie
                if (curr.Child[c - 'a'] == null)
                {
                    // If node for current character does
                    // not exist then make a new node
                    TrieNode2 newNode = new TrieNode2();

                    // Keep the reference for the newly created node
                    curr.Child[c - 'a'] = newNode;
                }

                // Move the curr pointer to the newly created node
                curr = curr.Child[c - 'a'];
            }

            // Mark the end of the word
            curr.WordEnd = true;
        }

        // Method to search a key in the Trie
        public bool SearchKey(TrieNode2 root, string key)
        {
            // Initialize the curr pointer with the root node
            TrieNode2 curr = root;

            // Iterate across the length of the string
            foreach (char c in key)
            {
                // Check if the node exists for the current
                // character in the Trie
                if (curr.Child[c - 'a'] == null)
                    return false;

                // Move the curr pointer to the already
                // existing node for the current character
                curr = curr.Child[c - 'a'];
            }

            // Return true if the word exists and
            // is marked as ending
            return curr.WordEnd;
        }
    }
}

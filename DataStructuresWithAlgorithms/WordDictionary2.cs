using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{
    public class WordDictionary2
    {
        private List<string> res = new List<string>();

        public List<string> FindWords(char[][] board, string[] words)
        {
            TrieNode3 root = new TrieNode3();
            for (int i = 0; i < words.Length; i++)
            {
                root.AddWord(words[i], i);
            }

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {
                    Dfs(board, root, r, c, words);
                }
            }

            return res;
        }

        private void Dfs(char[][] board, TrieNode3 node, int r, int c, string[] words)
        {
            if (r < 0 || c < 0 || r >= board.Length ||
                c >= board[0].Length || board[r][c] == '*' ||
                node.children[board[r][c] - 'a'] == null)
            {
                return;
            }

            char temp = board[r][c];
            board[r][c] = '*';
            TrieNode3 prev = node;
            node = node.children[temp - 'a'];
            if (node.idx != -1)
            {
                res.Add(words[node.idx]);
                node.idx = -1;
                node.refs--;
                if (node.refs == 0)
                {
                    node = null;
                    prev.children[temp - 'a'] = null;
                    board[r][c] = temp;
                    return;
                }
            }

            Dfs(board, node, r + 1, c, words);
            Dfs(board, node, r - 1, c, words);
            Dfs(board, node, r, c + 1, words);
            Dfs(board, node, r, c - 1, words);

            board[r][c] = temp;
        }
    }
}


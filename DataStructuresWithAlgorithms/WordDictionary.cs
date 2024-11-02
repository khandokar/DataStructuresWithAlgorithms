using System.Linq;

namespace DataStructuresWithAlgorithms
{
    public  class WordDictionary
    {
        private TrieNode root;
        public WordDictionary()
        {
            root= new TrieNode();
        }

        public void AddWord(string word)
        {
            TrieNode currentNode = root;
            char[] chars = word.ToCharArray();
            foreach(char currentChar in chars) 
            { 
              if(!currentNode.Childrean.ContainsKey(currentChar))
              {
                 currentNode.Childrean.Add(currentChar, new TrieNode());
              }
              currentNode= currentNode.Childrean[currentChar];
            }
            
            currentNode.IsWord = true;
        }

        public bool Search(string word)
        {     
            char[] chars = word.ToCharArray();

            return DoSearch(0, chars, root);
        }

        private bool DoSearch(int j, char[] chars, TrieNode node)
        {
            TrieNode currentNode = node;
            for (int i = j; i < chars.Length; i++)
            {
                if (chars[i] == '.')
                {
                    foreach (TrieNode child in currentNode.Childrean.Values.ToArray())
                    {
                        if (DoSearch(i + 1, chars, child))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                if (!currentNode.Childrean.ContainsKey(chars[i]))
                {
                    return false;
                }
                currentNode = currentNode.Childrean[chars[i]];
            }
            return currentNode.IsWord;
        }


    }
}

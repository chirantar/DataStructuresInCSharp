using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trie
{
    class Trie
    {
        static readonly int ALPHABET_SIZE = 26;

        class TrieNode
        {
            public TrieNode[] children = new TrieNode[ALPHABET_SIZE];
            public bool isEndOfWord;
            public TrieNode()
            {
                for (int i = 0; i < ALPHABET_SIZE; i++)
                {
                    children[i] = null;
                }
                isEndOfWord = false;
            }
        }

        static TrieNode root;

        public static void Insert(String key)
        {
            int size = key.Length;
            int index;
            TrieNode pCrawl = root;
            for (int i = 0; i < size; i++)
            {
                index = key[i] - 'a';
                if (pCrawl.children[index] == null)
                    pCrawl.children[index] = new TrieNode();

                pCrawl = pCrawl.children[index];

            }

            pCrawl.isEndOfWord = true;
        }

        public static bool Search(string key)
        {
            TrieNode pCrawl = root;
            int index;
            for (int i = 0; i < key.Length; i++)
            {
                index = key[i] - 'a';
                if (pCrawl.children[index] == null)
                    return false;
                pCrawl = pCrawl.children[index];
            }

            if (pCrawl != null && pCrawl.isEndOfWord == true)
                return true;

            return false;
        }
        static void Main(string[] args)
        {
            String[] keys = new string[]{"the", "is", "one", "place"};

            root = new TrieNode();

            foreach (string item in keys)
            {
                Insert(item);
            }

            Console.WriteLine(Search("one").ToString());
            Console.WriteLine(Search("two").ToString());

            Console.Read();

        }
    }
}

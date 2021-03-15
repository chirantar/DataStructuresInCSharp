using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Graphs
{
    public class Program
    {
        static public void Main()
        {

            List<int> val = ReadInputAndParseList();
            int v = val[0];
            int e = val[1];
            List<int>[] adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
            for (int i = 0; i < e; i++)
            {
                List<int> arr = ReadInputAndParseList();
                int x = arr[0];
                int y = arr[1];

                adj[x].Add(y);
                //adj[y].Add(x);
            }

            for (int i = 0; i < v; i++)
            {
                Console.Write($"{i}");
                foreach (var item in adj[i])
                {
                    Console.Write($"-> {item}");
                }
                Console.WriteLine();
            }
            BFS bfs = new BFS();
            List<int> bfsOut = bfs.BFSTraversal(adj, v);

            foreach (int item in bfsOut)
            {
                Console.Write($"{item}, ");
            }

            DFS dfs = new DFS();
            List<int> dfsOut = dfs.DFSTraversal(adj, v);

            foreach (int item in dfsOut)
            {
                Console.Write($"{item}, ");
            }
        }

        private static List<int> ReadInputAndParseList()
        {
            string[] str = Console.ReadLine().Split(' ');

            List<int> list = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                int val;
                if (int.TryParse(str[i], out val))
                {
                    list.Add(val);
                }
            }

            return list;
        }
    }
}

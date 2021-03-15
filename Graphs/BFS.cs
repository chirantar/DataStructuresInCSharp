using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Graphs
{
    public class BFS
    {
        public List<int> BFSTraversal(List<int>[] graph, int v)
        {
            List<int> ans = new List<int>();

            bool[] visited = new bool[v];

            Queue<int> q = new Queue<int>();
            q.Enqueue(v);

            while (q.Count > 0)
            {
                int vertex = q.Dequeue();
                visited[vertex] = true;
                ans.Add(vertex);
                foreach (var item in graph[vertex])
                {
                    if (visited[item] == false)
                    {
                        visited[item] = true;
                        q.Enqueue(item);
                    }
                }
            }

            return ans;
        }
    }
}

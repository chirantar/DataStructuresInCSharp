using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    class DFS
    {
        public List<int> DFSTraversal(List<int>[] graph, int v)
        {
            List<int> ans = new List<int>();
            bool[] visited = new bool[v];
            for (int i = 0; i < v; i++)
            {
                if (visited[i] == false)
                {
                    visited[i] = true;
                    DFSTraversalUtil(graph, i, ans, visited);
                }
            }
            return ans;
        }

        private void DFSTraversalUtil(List<int>[] graph, int vertex, List<int> ans, bool[] visited)
        {

            ans.Add(vertex);
            foreach (int edge in graph[vertex])
            {
                if (visited[edge] == false)
                {
                    visited[edge] = true;
                    DFSTraversalUtil(graph, edge, ans, visited);
                }
            }
        }
    }
}

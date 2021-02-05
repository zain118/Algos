using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Graph
    {
        public static List<List<int>> CreateUnDirectedAdj(List<int[]> edges, int V)
        {
            List<List<int>> adj = new List<List<int>>();
            for (int k = 0; k < V; k++)
            {
                List<int> lt = new List<int>();
                adj.Add(lt);
            }

            for (int m = 0; m < edges.Count; m++)
            {
                adj[edges[m][0]].Add(edges[m][1]);
                adj[edges[m][1]].Add(edges[m][0]);
            }

            return adj;
        }
        public static List<List<int>> CreateDirectedAdj(List<int[]> edges, int V)
        {
            List<List<int>> adj = new List<List<int>>();
            for (int k = 0; k < V; k++)
            {
                List<int> lt = new List<int>();
                adj.Add(lt);
            }

            for (int m = 0; m < edges.Count; m++)
            {
                adj[edges[m][0]].Add(edges[m][1]);
            }

            return adj;
        }

        public static List<int> bfsOfGraph(int V, List<List<int>> adj)
        {
            // Code here
            if (adj.Count == 0) return new List<int>();
            Queue<int> q = new Queue<int>();
            bool[] b = new bool[V];
            List<int> list = new List<int>();
            q.Enqueue(0);
            b[0] = true;
            while (q.Count != 0)
            {
                int top = q.Dequeue();
                list.Add(top);
                
                foreach (int l in adj[top])
                {
                    if (!b[l])
                    {
                        b[l] = true;
                        q.Enqueue(l);
                    }  
                }
            }
            return list;

        }

        public static List<int> RecursiveBFS(int V, List<List<int>> adj)
        {
            // Code here
            List<int> list = new List<int>();
            list.Add(0);
            bool[] vis = new bool[V];
            list = BFSRecFunCall(list, adj, vis, 0, 0);
            return list;
        }

        static List<int> BFSRecFunCall(List<int> list, List<List<int>> adj, bool[] vis, int firstLevel, int secondLevel)
        {
            if (adj[firstLevel].Count == 0) return list;
            if (!vis[adj[firstLevel][secondLevel]])
            {
                list.Add(adj[firstLevel][secondLevel]);
                vis[adj[firstLevel][secondLevel]] = true;
            }
            if (secondLevel + 1 < adj[firstLevel].Count)
                BFSRecFunCall(list, adj, vis, firstLevel, secondLevel + 1);
            else if (firstLevel + 1 < adj.Count)
                BFSRecFunCall(list, adj, vis, firstLevel + 1, 0);

            return list;
        }


        public static List<int> RecursiveDFS(int V, List<List<int>> adj)
        {
            // Code here
            List<int> list = new List<int>();
            bool[] vis = new bool[V];
            list = DFSRecFunCall(list, adj, vis, 0);
            return list;
        }

        static List<int> DFSRecFunCall(List<int> list, List<List<int>> adj, bool[] vis, int index)
        {
            list.Add(index);
            vis[index] = true;
            foreach (int item in adj[index])
            {
                if (!vis[item])
                {
                    DFSRecFunCall(list, adj,  vis, item);
                }
            }

            return list;
        }

    }
}

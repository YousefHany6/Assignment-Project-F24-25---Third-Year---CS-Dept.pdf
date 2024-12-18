using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Project_F24_25___Third_Year___CS_Dept.pdf
{
	public static class Kruskal_s_algorithm
	{
		public class Edge
		{
			public int u, v, weight;
			public Edge(int u, int v, int weight)
			{
				this.u = u;
				this.v = v;
				this.weight = weight;
			}
		}

		public class DisjointSet
		{
			int[] parent, rank;

			public DisjointSet(int n)
			{
				parent = new int[n];
				rank = new int[n];
				for (int i = 0; i < n; i++)
				{
					parent[i] = i;
					rank[i] = 0;
				}
			}

			public int Find(int u)
			{
				if (parent[u] != u)
					parent[u] = Find(parent[u]);
				return parent[u];
			}

			public void Union(int u, int v)
			{
				int rootU = Find(u);
				int rootV = Find(v);

				if (rootU != rootV)
				{
					if (rank[rootU] > rank[rootV])
						parent[rootV] = rootU;
					else if (rank[rootU] < rank[rootV])
						parent[rootU] = rootV;
					else
					{
						parent[rootV] = rootU;
						rank[rootU]++;
					}
				}
			}
		}

		public static int Kruskal(List<Edge> edges, int n)
		{
			edges.Sort((e1, e2) => e1.weight.CompareTo(e2.weight));

			DisjointSet ds = new DisjointSet(n);
			int mstWeight = 0;
			int edgesInMST = 0;

			foreach (var edge in edges)
			{
				if (ds.Find(edge.u) != ds.Find(edge.v))
				{
					ds.Union(edge.u, edge.v);
					mstWeight += edge.weight;
					edgesInMST++;
					if (edgesInMST == n - 1) break;
				}
			}

			return mstWeight;
		}
	}
}

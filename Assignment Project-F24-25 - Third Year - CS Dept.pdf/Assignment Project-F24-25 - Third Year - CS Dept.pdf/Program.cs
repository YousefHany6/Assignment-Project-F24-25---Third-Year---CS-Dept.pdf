using static Assignment_Project_F24_25___Third_Year___CS_Dept.pdf.Kruskal_s_algorithm;

namespace Assignment_Project_F24_25___Third_Year___CS_Dept.pdf
{
	public class Program
	{
		static void Main(string[] args)
		{
			//int[] data = { 12, 11, 13, 5, 6, 7 };
			//Console.WriteLine("Original array:");
			//Console.WriteLine(string.Join(" ", data));
			//HeapSort.HeapSortAlgorithm(data);
			//Console.WriteLine("Sorted array:");
			//Console.WriteLine(string.Join(" ", data));
			List<Edge> edges = new List<Edge>
								{
												new Edge(0, 1, 10),
												new Edge(0, 2, 6),
												new Edge(0, 3, 5),
												new Edge(1, 3, 15),
												new Edge(2, 3, 4)
								};

			int n = 4; // Number of vertices
			int mstWeight = Kruskal(edges, n);

			Console.WriteLine("Weight of MST: " + mstWeight);
		}
	}
}

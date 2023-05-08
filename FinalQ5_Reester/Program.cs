using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ6_Reester
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //0 -red, 1 gray, 2 Drk Blue, 3 Light Blue, 4 Orange, 5 Yellow, 6 Purple, 7 Green
            int[,] adjacencyMatrix = {
                { 0, 5, 1, 0, 0, 0, 0, 0 }, //0
                { 0, 0, 0, 0, 1, 0, 0, 0 }, //1
                { 0, 0, 0, 1, 0, 0, 0, 0 }, //2
                { 0, 0, 1, 0, 0, 0, 0, 0 }, //3
                { 0, 0, 0, 0, 0, 0, 1, 0 }, //4
                { 0, 0, 0, 0, 0, 0, 1, 6 }, //5
                { 0, 0, 0, 0, 0, 1, 0, 0 }, //6
                { 0, 0, 0, 0, 0, 1, 0, 0 }, //7
            };

            List<(int, int)> edgeList = new List<(int, int)>();

            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                for (int j = i; j < adjacencyMatrix.GetLength(1); j++)
                {
                    if (adjacencyMatrix[i, j] != 0)
                    {
                        edgeList.Add((i + 1, j + 1));
                    }
                }
            }

            Dictionary<int, int> distances = new Dictionary<int, int>();
            Dictionary<int, int> previous = new Dictionary<int, int>();
            List<int> unvisited = new List<int>();

            // Initialize distances with infinity except for the start node
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                distances[i] = int.MaxValue;
                unvisited.Add(i);
            }

            distances[0] = 0;

            while (unvisited.Any())
            {
                int current = unvisited.OrderBy(x => distances[x]).First();
                unvisited.Remove(current);

                for (int neighbor = 0; neighbor < adjacencyMatrix.GetLength(1); neighbor++)
                {
                    if (adjacencyMatrix[current, neighbor] != 0)
                    {
                        int alt = distances[current] + adjacencyMatrix[current, neighbor];
                        if (alt < distances[neighbor])
                        {
                            distances[neighbor] = alt;
                            previous[neighbor] = current;
                        }
                    }
                }
            }

            // Output shortest path from red to green
            List<int> path = new List<int>();
            int destination = 7;
            while (previous.ContainsKey(destination))
            {
                path.Add(destination);
                destination = previous[destination];
            }
            path.Add(destination);
            path.Reverse();

            // Map color numbers to their respective names
            Dictionary<int, string> colors = new Dictionary<int, string>
            {
                {0, "red"},
                {1, "gray"},
                {2, "Drk Blue"},
                {3, "Light Blue"},
                {4, "Orange"},
                {5, "Yellow"},
                {6, "Purple"},
                {7, "Green"}
            };

            // Output shortest path of colors from red to green
            string shortestPath = string.Join(" -> ", path.Select(p => colors[p]));
            Console.WriteLine("Shortest path from red to green: " + shortestPath);
        }
    }
    
}

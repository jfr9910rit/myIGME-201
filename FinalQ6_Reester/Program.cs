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
        }
    }
}

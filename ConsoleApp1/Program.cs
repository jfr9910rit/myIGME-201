using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,,] calculations;
            for (double x = -1; x <= 1; x += 0.1)
            {
                for(double y = 1; y <= 4; y += 0.1) { 
                    double z = 3*(Math.Pow(y,2)) + (2*(x) - 1);
                    calculations[x, y,] = z;
                }
            }
        }
    }
}

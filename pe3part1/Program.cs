using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe3part1
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, product;
            Console.WriteLine("Enter Four Numbers : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            product = num1 * num2 * num3 * num4;
            Console.WriteLine("Product of Numbers = " + product);
        }
    }
}

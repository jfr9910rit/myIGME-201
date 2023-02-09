using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe8part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a string: ");
            string str = Console.ReadLine();
            string str2 = "";
            int len = str.Length -1;
            for(int i = len; i > 0; i--)
            {
                str2 = str2 + str[i];
            }
            str2 += str[0];
            Console.WriteLine("The reverse string is: " + str2);
        }
    }
}

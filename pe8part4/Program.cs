using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe8part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            var x = input.Split(' ').Select(a => "\"" + a + "\"");
            foreach (var s in x)
            {
                Console.WriteLine(s);
            }
           
        }
    }
}

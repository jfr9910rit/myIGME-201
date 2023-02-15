using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe9part2
{
    internal class Program
    {

        delegate string Reader();
        static void Main(string[] args)
        {
            Reader reader = new Reader(ReadText);
            Console.WriteLine("Type below");
            Console.WriteLine();
            string test = reader();
            Console.WriteLine(test);
        }

        public static string ReadText()
        {
            return Console.ReadLine();

        }
    }
}

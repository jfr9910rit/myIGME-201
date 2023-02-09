using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace pe8part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string with the word no:");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            for (int i = 0; i < splitInput.Length; i++)
            {
                if (splitInput[i] == "no")
                {
                    splitInput[i] = "yes";
                }
                else if (splitInput[i] == "No")
                {
                    splitInput[i] = "Yes";
                }
                else if (splitInput[i] == "NO")
                {
                    splitInput[i] = "YES";
                }
                else if (splitInput[i] == "nO")
                {
                    splitInput[i] = "yES";
                }
            }
            Console.WriteLine(string.Join(" ", splitInput.ToArray()));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reester_PE1
{
    //Class: Program
    //Author: Julian Reester
    //Purpose: Console Read/Write and Exception-handling excercise
    //Restrictions: None
    internal class Program
    {
        static void Main(string[] args)
        {
            //writes hello world to console
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Julian Reester");

            int nNum1 = 3;
            int nNum2 = 5;
            int nNum3 = nNum1 + nNum2;
            if(nNum3 < 10)
            {
                Console.WriteLine(nNum3);
            }
            
        }
    }
}

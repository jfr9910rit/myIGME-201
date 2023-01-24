using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: Julian Reester
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //syntax error - missing semi colon
            //logic error - int doesnt allow decimals so changed to float or all outputs aside from the first 2 are 1
            //int i = 0
            float i = 0;

            // declare string to hold all numbers
            //logic error - was scoped inside for loop block, moved out of loop to declare
            string allNumbers = null;

            // loop through the numbers 1 through 10
            //logic error - stops at 10 rather than running 10, changed to run 10
            //for (i = 1; i < 10; ++i)
            for (i = 1; i < 11; ++i)
            {
                

                // output explanation of calculation
                //logic error - missing parenthesis for operation in console write
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                //runtime error - on first loop would cause 1/0 to produce divide by 0 error
                //added if else statement to tell if i = 1 so it produces a meesage instead of breaking
                if(i == 1)
                {
                    Console.WriteLine("Unable to divide 1 by 0");
                }
                else
                {
                    Console.WriteLine(i / (i - 1));
                }
                

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //runtime error - counter already incements as part of the loop so it is removed
                //i = i + 1;
            }

            // output all numbers which have been processed
            //syntax error - missing + between string and variable
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }   
    }

}

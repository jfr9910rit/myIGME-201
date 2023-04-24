using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1Part7_Reester
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY - compile time syntax error missing semiciolon
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); - compile time syntax error missing quotation marks around string
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); compile time error - sNumber is undefined as it is not setting readline to store the value in sNumber
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } //while (int.TryParse(sNumber, out nX)); - compile time error when calling power function nY is unnasigned as it is just reassigning nX and logic error needs ! in front
            while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}"); - logic error does not use variables but just has them as part of the string
            //Console.WriteLine("{nX}^{nY} = {nAnswer}", nX, nY, nAnswer); - runtme error needs to use index instead of variable names to refernce the variables in a string
            Console.WriteLine("{0}^{1} = {2}", nX, nY, nAnswer);
        }

        // logic error needed to be declared outside power function and set to 1 so it isnt always to 0]
        static int returnVal = 1;
        //int Power(int nBase, int nExponent) - compile time error unable to call because it is not static
        static int Power(int nBase, int nExponent)
        {
            
            //not needed
            //int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0; - logic error sets the rurn value to 0 so it always returns 0, instead just returns the value
                //returnVal; - compile time error needs return in fron to return the returnVal
                return returnVal;
            }
            else
            {
                // multiply the base with all subsequent values
                //returnVal = nBase * nextVal; logic error did nothing by multiplying by next val
                returnVal *= nBase;
                

                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1); - runtime error needs to be - 1 instead of +1 or it is infinite
                //logic error needs to be last or will never do anything before recalling Power, also did not need nextVal = to make it recaall
                Power(nBase, nExponent - 1);
            }
            //returnVal; - compile time error needs return in fron to return the returnVal
            return returnVal;

        }
    }

}

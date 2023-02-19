using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1Part5_Reester
{
    internal class Program
    {
        static string sName = "Julian";
        static double dSalary = 30000;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            if (GiveRaise(userName, ref dSalary))
            {
                Console.WriteLine("Congratulations " + userName + "!");
                Console.WriteLine("Your new salary is " + dSalary);
            }
            else
            {
                Console.WriteLine("Sorry " + userName + " you did not recieve a raise.");
            }


        }

        static bool GiveRaise(string name, ref double salary)
        {
            if (string.Equals(name,sName, StringComparison.CurrentCultureIgnoreCase))
            {
                dSalary = salary + 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
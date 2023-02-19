using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1Part6_Reester
{
    internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
            public string userName;

            
        }

        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.sName = "Julian";
            emp.dSalary = 30000;
            Console.WriteLine("Please enter your name: ");
            emp.userName = Console.ReadLine();
            GiveRaise(emp);
            


        }

        static bool GiveRaise(employee emp)
        {
            if (string.Equals(emp.userName, emp.sName, StringComparison.CurrentCultureIgnoreCase))
            {
                emp.dSalary += 19999.99;
                Console.WriteLine("Congratulations " + emp.userName + "!");
                Console.WriteLine("Your new salary is " + emp.dSalary);
                return true;
            }
            else
            {
                Console.WriteLine("Sorry " + emp.userName + " you did not recieve a raise.");
                return false;
            }
        }
    }
}


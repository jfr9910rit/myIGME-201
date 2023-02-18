using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1Part3_Reester
{
    internal class Program
    {
        delegate double Round(string number,int length);
        static void Main(string[] args)
        {
            Round round = new Round(RoundNum);
            Console.WriteLine("enter a number to round:");
            string doub = Console.ReadLine();
            Console.WriteLine("enter the amount of decimal places");
            int len = Convert.ToInt32(Console.ReadLine());
            double dOut = round(doub,len);
            Console.WriteLine();
            Console.WriteLine(dOut);
        }

        public static double RoundNum(string number, int length) 
        {

            char[] nums = number.ToCharArray();
            char[] outString= new char[nums.Length];
            int stringLength = nums.Length;
            
            for (int i = 0; i < stringLength; i++)
            {
                if (number.Contains("."))
                {

                    if (i == length)
                    {
                        if (Convert.ToInt32(nums[i + 1]) >= 53)
                        {
                            
                            nums[i] = Convert.ToChar(Convert.ToInt32(nums[i]) + 1);
                            outString[i] = nums[i];
                            break;
                        }
                        else
                        {
                            outString[i] = nums[i];
                            break;
                        }
                    }
                    
                }
                else
                {
                    if (i == length-1)
                    {
                        if (Convert.ToInt32(nums[i + 1]) >= 53)
                        {
                            nums[i] = Convert.ToChar(Convert.ToInt32(nums[i]) + 1);
                            outString[i] = nums[i];
                            break;
                        }
                        else
                        {
                            outString[i] = nums[i];
                            break;
                        }
                    }
                }
                outString[i] = nums[i];
            }
            double finalOut = Convert.ToDouble(string.Join("",outString));
            return finalOut;
        }
    }
}

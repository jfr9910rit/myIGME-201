using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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




            //question 8
            int count = 1;
            double[,,] calculations = new double[21,31,651];
            for (double x = -1; x <= 1; x += 0.1)
            {
                for (double y = 1; y <= 4; y += 0.1)
                {
                    double z = 4 * (Math.Pow(y, 3)) + 2 * (Math.Pow(x, 2)) - (8 * x) + 7;
                    calculations[(int)x, (int)y, (int)z] = count++;
                }
            }
            for (double i  = -1; i <= 1; i += 0.1)
            {
                for (double j = 1; j <= 4; j += 0.1)
                {
                    for(double k = 1;k <= 651; k ++)
                    {
                        double roundedX = round(Convert.ToString(calculations[(int)i, (int)j, (int)k]), 1);
                        double roundedY = round(Convert.ToString(calculations[(int)i, (int)j, (int)k]), 1);
                        double roundedZ = round(Convert.ToString(calculations[(int)i, (int)j, (int)k]), 3);
                    }
                    
                }
            }

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

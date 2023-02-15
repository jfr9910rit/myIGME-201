using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ColorNameSpace
{
    //Class: NumberClass
    //Author: Julian Reester
    //Purpose:Class to contain user's favorite color
    //Restrictions: None
    namespace Color
    {
        static class ColorClass
        {
            public static string sFavColor = null;
        }
    }
}



namespace FavoriteColorAndNumber
{
    using CAlias = ColorNameSpace.Color;

    //Class: Program
    //Author: Julian Reester
    //Purpose: Console Read/Write and Exception-handling excercise
    //Restrictions: None


    internal class Program
    {
        static void Main(string[] args)
        {
            int nFavNum = 0;
            string sFavNum = null;
            sFavNum = "123";
            int? npFavNum = null;



            Int32 nFavNumber = 0;

            Console.WriteLine("Hello World");

            //prompt the user for their favorite color
            Console.WriteLine("Enter your Favorite color: \t");
            //read from the console what their fav color is and store it in variabale
            CAlias.ColorClass.sFavColor = Console.ReadLine();

            //prompt user for favorite number
            Console.WriteLine("Enter your Favorite number: \t");

            do
            {
                //read from the console what their fav color is and store it in variabale
                sFavNum = Console.ReadLine();

                try
                {
                    nFavNum = Convert.ToInt32(sFavNum);
                }
                catch
                {
                    Console.WriteLine("Please enter an integer.");
                }
            } while (npFavNum == null);
            

            //change text to match their color

            //output fav color their fav number of times
        }
    }
}

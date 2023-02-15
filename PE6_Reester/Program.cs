using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Reester
{
    // Class Program
    // Author: Julian Reester
    // Purpose: Number guessing game
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: A loop that increases on valid guesses and stops on correct guess or out of guesses
        // Restrictions: None
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            Console.WriteLine(randomNumber.ToString());
            //while loop counter
            int i = 1;
            while(i < 9)
            {
                //asks for guess and puts it in variable
                Console.WriteLine("Turn " + i + ": Enter your guess: ");
                int entry = Convert.ToInt32(Console.ReadLine());
                //if statements depending on if guess matches number or is not valid
                if(entry == randomNumber)
                {
                    Console.WriteLine("Congratulations you guessed correctly.");
                    break;
                }
                else if (entry < 0 || entry > 100)
                {
                    Console.WriteLine("Invalid guess: try again");
                }
                else if (entry < randomNumber)
                {
                    Console.WriteLine("Too low");
                    i++;
                }
                else if (entry > randomNumber)
                {
                    Console.WriteLine("Too high");
                    i++;
                }
                
            }
            //if statement for if out of tries
            if(i == 9)
            {
                Console.WriteLine("You failed to guess in 8 turns");
            }
        }
    }
}

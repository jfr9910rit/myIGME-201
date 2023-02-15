using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Reester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            Console.WriteLine(randomNumber.ToString());
            int i = 1;
            while(i < 9)
            {
                Console.WriteLine("Turn " + i + ": Enter your guess: ");
                int entry = Convert.ToInt32(Console.ReadLine());
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
            if(i == 9)
            {
                Console.WriteLine("You failed to guess in 8 turns");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1Part4_Reester
{
    internal class Program
    {
        public static System.Timers.Timer aTimer;
        static void Main(string[] args)
        {

            aTimer = new System.Timers.Timer(5000);
            bool play = true;
            while(play)
            {
                Console.WriteLine("Choose your question (1-3):");
                int qNumber = Convert.ToInt32(Console.ReadLine());
                int playTest = 0;
                if (qNumber== 1)
                {
                    aTimer = new System.Timers.Timer(5000);
                    string ans = "black";
                    aTimer.Elapsed += (sender, e) =>
                    {
                        Console.WriteLine("Time's up!");
                        Console.WriteLine("The answer is: " + ans);
                        Console.WriteLine("Please press enter.");
                    };
                    
                    Console.WriteLine("You have 5 seconds to answer the following question:");
                    aTimer.Enabled = true;
                    Console.WriteLine("What is your favorite color ?");
                    string response = Console.ReadLine();
                    if(response.Equals(ans, StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        Console.WriteLine("Well Done!");
                        aTimer.Stop();
                    }
                    else if (response.Equals("", StringComparison.CurrentCultureIgnoreCase))
                    {
                        aTimer.Stop();
                    }
                    else if(response.Equals(ans, StringComparison.CurrentCultureIgnoreCase) == false)
                    {
                        Console.WriteLine("Wrong!  The answer is: " + ans);
                        aTimer.Stop();
                    }
                    
                    while(playTest == 0)
                    {
                        Console.WriteLine("Play again? ");
                        string playAgain = Console.ReadLine();
                        if (playAgain.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                        {
                            play = false;
                            break;
                        }
                        else if (playAgain.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                        {
                            playTest++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Play again? ");
                            playAgain = Console.ReadLine();
                        }
                    }
                    
                }
                else if (qNumber == 2)
                {
                    aTimer = new System.Timers.Timer(5000);
                    string ans = "42";
                    aTimer.Elapsed += (sender, e) =>
                    {
                        Console.WriteLine("Time's up!");
                        Console.WriteLine("The answer is: " + ans);
                        Console.WriteLine("Please press enter.");
                    };

                    Console.WriteLine("You have 5 seconds to answer the following question:");
                    aTimer.Enabled = true;
                    Console.WriteLine("What is the answer to life, the universe and everything? ");
                    string response = Console.ReadLine();
                    if (response.Equals(ans, StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        Console.WriteLine("Well Done!");
                        aTimer.Stop();
                    }
                    else if (response.Equals("", StringComparison.CurrentCultureIgnoreCase))
                    {
                        aTimer.Stop();
                    }
                    else if (response.Equals(ans, StringComparison.CurrentCultureIgnoreCase) == false)
                    {
                        Console.WriteLine("Wrong!  The answer is: " + ans);
                        aTimer.Stop();
                    }

                    while (playTest == 0)
                    {
                        Console.WriteLine("Play again? ");
                        string playAgain = Console.ReadLine();
                        if (playAgain.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                        {
                            play = false;
                            break;
                        }
                        else if (playAgain.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                        {
                            playTest++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Play again? ");
                            playAgain = Console.ReadLine();
                        }
                    }

                }
                else if (qNumber == 3)
                {
                    aTimer = new System.Timers.Timer(5000);
                    string ans = "What do you mean? African or European swallow?";
                    aTimer.Elapsed += (sender, e) =>
                    {
                        Console.WriteLine("Time's up!");
                        Console.WriteLine("The answer is: " + ans);
                        Console.WriteLine("Please press enter.");
                    };

                    Console.WriteLine("You have 5 seconds to answer the following question:");
                    aTimer.Enabled = true;
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow? ");
                    string response = Console.ReadLine();
                    if (response.Equals(ans, StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        Console.WriteLine("Well Done!");
                        aTimer.Stop();
                    }
                    else if (response.Equals("", StringComparison.CurrentCultureIgnoreCase))
                    {
                        aTimer.Stop();
                    }
                    else if (response.Equals(ans, StringComparison.CurrentCultureIgnoreCase) == false)
                    {
                        Console.WriteLine("Wrong!  The answer is: " + ans);
                        aTimer.Stop();
                    }

                    while (playTest == 0)
                    {
                        Console.WriteLine("Play again? ");
                        string playAgain = Console.ReadLine();
                        if (playAgain.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                        {
                            play = false;
                            break;
                        }
                        else if (playAgain.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                        {
                            playTest++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Play again? ");
                            playAgain = Console.ReadLine();
                        }
                    }

                }
            }
        }
    }
}

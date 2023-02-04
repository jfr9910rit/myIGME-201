using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PE7_Reester
{
    // Class Program
    // Author: Julian Reester
    // Purpose: Mad Libs Game
    // Restrictions: None
    static internal class Program
    {
        // Method: Main
        // Purpose: after prompting if wants to play takes the text file and asks user for which one they want to play
        // then goes through the prompts and asks the user to fill in the blanks, ends with output of what they enetered filled in
        // Restrictions: None
        static void Main(string[] args)
        {
            //loop to control if they want to play or ot and if guess is valid
            int l = 0;
            while(l < 1)
            {
                Console.WriteLine("Would you like to play Mad Libs? Enter yes or no:");
                string answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "no")
                {
                    //if no ends loop and says goodbye
                    Console.WriteLine("Goodbye");
                    l++;
                }
                else if (answer == "yes")
                {
                    //plays game if yes
                    //loading in text file
                    StreamReader input = new StreamReader("E:\\201\\MadLibsTemplate.txt");
                    //variable for amount of stories
                    int count = File.ReadAllLines("E:\\201\\MadLibsTemplate.txt").Length;
                    Console.WriteLine("Enter which story you would like to do: 1-" + count);
                    int storyNum = Convert.ToInt32(Console.ReadLine());
                    string resultString;
                    //creates list of stories
                    List<string> lines = new List<string>();
                    string line;
                    while ((line = input.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    //takes chosen story and splits it into words
                    string[] splitLine = lines[storyNum].Split(' ');
                    //loops through story until done
                    for (int i = 0; i < splitLine.Length; i++)
                    {
                        //makes an array of chars for each word
                        char[] splitWord = splitLine[i].ToCharArray();
                        //detects if first char is { for is it is input
                        if (splitWord[0] == '{')
                        {
                            //asks for input and replaces blank
                            Console.WriteLine("Please enter a/an: " + splitLine[i].Trim('{', '}', ',').Replace('_', ' '));
                            string fillWord = Console.ReadLine();
                            splitLine[i] = fillWord;
                        }
                        //detects for \n in text file
                        else if (splitLine[i].Equals("\\n"))
                        {
                            //puts newline in its place
                            splitLine[i] = "\n";
                        }

                    }
                    //makes result string into the output of the filled out mad lib
                    resultString = string.Join(" ", splitLine.ToArray());
                    //prints result and ends loop
                    Console.WriteLine(resultString);
                    l++;
                }
                else
                {
                    //if invalid response prompts the user to enter valid answer and repeats loop
                    Console.WriteLine("Invalid entry please enter yes or no");
                }
            }
            
            

            
        }
    }
}
    
    


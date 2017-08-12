using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    /// <summary>
    /// Entry point for magic 8 ball program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
           //Preserver current console text color 
            ConsoleColor oldColor = Console.ForegroundColor;

            TellPeopleWhatProgramThisIs();

            // Creat a randomizer object
            Random randomObject = new Random();

            while (true)
            {
                string questionString = GetQuestionFromUser();

                //Make the computer pause for between 1 and 5 seconds
                // Before continuing
                int numberOfSecondsToSleep = randomObject.Next(5) + 1;
                Console.WriteLine("Thinking about your answer, stand by...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);                 

                if( questionString.Length == 0)
                {
                    Console.WriteLine("You need to type a question fool!");
                    continue;
                }

                //see if the user typed quit as the question
                if(questionString.ToLower() == "quit")
                {
                    break;
                }

                if(questionString.ToLower() == "you suck")
                {
                    Console.WriteLine("You suck even more! Bye!");
                    break;
                }

                // Get a random #
                int randomNumber = randomObject.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomNumber;


                // Use random number to determine response
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("YES!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("NO!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("HELL NO!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("HELL YES!");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("OMG WTF YES!");
                            break;
                        }


                }        

            }


            // Cleaning up
            Console.ForegroundColor = oldColor;
        }


        /// <summary>
        /// This will print the name of the program and who created it
        /// to the console
        /// </summary>
        static void TellPeopleWhatProgramThisIs()
        {
            // Change console text color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("M");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("agic 8 Ball (by: Dylan)");
        }

        /// <summary>
        /// This text will return the question the user types
        /// </summary>
        static string GetQuestionFromUser()
        {
            // This block of code will ask the user for a question
            // and store the question text in questionString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string questionString = Console.ReadLine();

            return questionString;
        }
    }
}

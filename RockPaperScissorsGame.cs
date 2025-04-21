using System;
using System.Xml;

namespace HelloSoftUni
{


    class RockPaperScissorsGame
    {

        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
            const string Quit = "Quit";

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";

            Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerInput = Console.ReadLine();
                         

                if (playerInput == "r" || playerInput == "rock")
                {
                    playerInput = Rock;
                }
                else if (playerInput == "p" || playerInput == "paper")
                {
                    playerInput = Paper;
                }
                else if (playerInput == "s" || playerInput == "scissors")
                {
                    playerInput = Scissors;
                }

                else
                {
                    Console.WriteLine("Invalid input. Please try again...");
                    return;
                }

                switch (computerRandomNumber)
                {
                    default:
                        Console.WriteLine("Not a number");
                        break;
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }
                Console.WriteLine($"The computer choose {computerMove} .");

                if ((playerInput == Rock && computerMove == Scissors) ||
                    (playerInput == Paper && computerMove == Rock) ||
                    (playerInput == Scissors && computerMove == Paper))
                {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win."); 
            }

                else if ((playerInput == Rock && computerMove == Paper) ||
                    (playerInput == Paper && computerMove == Scissors) ||
                    (playerInput == Scissors && computerMove == Rock))
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You loose."); 
            }
                else
                {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("The game was a draw."); 
            }
            
            





        }
    }
}



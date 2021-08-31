using System;
using System.Collections.Generic;

namespace free_rps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // int[] choice = new int[3] { 1, 2, 3 };
            int playerNum = 0;
            int compNum = 0;
            bool gameLoop = true;
            string answer = "";

            while (gameLoop && answer != "N")
            {
                System.Console.WriteLine("Choose: \n-> 1. ROCK \n-> 2. PAPER \n-> 3. SCISSORS");
                int[] options = new int[3] { 1, 2, 3 };

                Random random = new Random();
                int num = random.Next(0, 3);
                System.Console.WriteLine("----------------------------\n Please Enter: 1, 2, or 3 \n----------------------------");
                string userChoice = System.Console.ReadLine();

                switch (options[num])
                {
                    case 1:
                        if (userChoice == "1")
                        {

                            Console.WriteLine("----------------------------\n         User chose ROCK");
                            Console.WriteLine("         Computer chose ROCK");
                            Console.WriteLine("         It is a tie. \n----------------------------");
                        }
                        else if (userChoice == "2")
                        {
                            Console.WriteLine("----------------------------\n         User chose PAPER");
                            Console.WriteLine("         Computer chose ROCK");
                            Console.WriteLine("         User Wins. \n----------------------------");
                            playerNum++;
                        }
                        else if (userChoice == "3")
                        {
                            Console.WriteLine("----------------------------\n         User chose SCISSORS");
                            Console.WriteLine("         Computer chose ROCK");
                            Console.WriteLine("         Computer wins. \n----------------------------");
                            compNum++;
                        }
                        break;
                    case 2:
                        if (userChoice == "1")
                        {
                            Console.WriteLine("----------------------------\n         User chose ROCK");
                            Console.WriteLine("         Computer chose PAPER");
                            Console.WriteLine("         It is a tie \n----------------------------");
                        }

                        else if (userChoice == "2")
                        {
                            Console.WriteLine("----------------------------\n         User chose PAPER");
                            Console.WriteLine("         Computer chose PAPER");
                            Console.WriteLine("         User wins \n----------------------------");
                            playerNum++;
                        }
                        else if (userChoice == "3")
                        {
                            Console.WriteLine("----------------------------\n         User chose SCISSORS");
                            Console.WriteLine("         Computer chose PAPER");
                            Console.WriteLine("         Computer wins \n----------------------------");
                            compNum++;
                        }
                        break;
                    case 3:
                        if (userChoice == "1")
                        {
                            Console.WriteLine("----------------------------\n         User chose ROCK");
                            Console.WriteLine("         Computer chose SCISSORS");
                            Console.WriteLine("         User wins. \n----------------------------");
                            playerNum++;
                        }

                        else if (userChoice == "2")
                        {
                            Console.WriteLine("----------------------------\n         User chose PAPER");
                            Console.WriteLine("         Computer chose SCISSORS");
                            Console.WriteLine("         Computer wins. \n----------------------------");
                            compNum++;
                        }
                        else if (userChoice == "3")
                        {
                            Console.WriteLine("----------------------------\n         User chose SCISSORS");
                            Console.WriteLine("         Computer chose SCISSORS");
                            Console.WriteLine("         It is a tie. \n----------------------------");
                        }
                        break;
                }
                System.Console.WriteLine("***************************************\n    Do you wish to play again?");
                System.Console.WriteLine("           Enter Y or N \n***************************************");
                answer = Console.ReadLine();
                if (answer == "N" || answer == "n" || answer == "no")
                {
                    gameLoop = false;
                    Console.Clear();
                    Console.WriteLine($"***************************************||***************************************||*************************************** \n***************************************          User has {playerNum} points         *************************************** \n***************************************         Computer has {compNum} points          *************************************** \n***************************************||***************************************||***************************************");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock2
{
    internal interface Rocknormal
    {
        public static void RunGame()
        {
            int score = 0;
            while (score < 4)
            {
                Console.WriteLine();
                Console.WriteLine(" choose rock, paper, or scissors?");
                Console.WriteLine("_______________________________");
                string userChoice = Console.ReadLine().ToLower();

                Random r = new Random();
                int computerChoice = r.Next(3) + 1;

                if (computerChoice == 1)
                {
                    if (userChoice == "rock")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie ");
                        Console.WriteLine($"your score is{score}");
                    }
                    else if (userChoice == "paper")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie ");
                        Console.WriteLine($"your score is{score}");
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");
                        Console.WriteLine($"your score is{score}");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper, or scissors!");
                    }
                }
                else if (computerChoice == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Sorry, you lose. Paper beats rock");
                        Console.WriteLine($"your score is{score}");
                    }
                    else if (userChoice == "paper")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry, you lose. Scissors beat paper ");
                        Console.WriteLine($"your score is{score}");
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry, you lose. Rock beats scissors");
                        Console.WriteLine($"your score is{score}");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper, or scissors!");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "rock")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You win. Rock beats scissors");
                        Console.WriteLine($"your score is{score}");
                        score++;
                    }
                    else if (userChoice == "paper")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You win. Paper beats rock");
                        Console.WriteLine($"your score is{score}");
                        score++;
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You win. Scissors beat paper");
                        Console.WriteLine($"your score is{score}");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper, or scissors!");
                    }
                }
            }
        }
    }
}
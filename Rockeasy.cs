using System.Text;
using System.Threading.Tasks;

namespace Rock
{
    internal interface Rockeasy
    {
        public static void RunGame()
        {
            int score = 0;
            while (score < 1)
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

                    }
                    else if (userChoice == "paper")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie ");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");

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

                    }
                    else if (userChoice == "paper")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry, you lose. Scissors beat paper ");
                    }


                    else if (userChoice == "scissors")
                    {
                        Console.Clear();
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry, you lose. Rock beats scissors");

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

                            score++;
                        }
                        else if (userChoice == "paper")
                        {
                            Console.Clear();
                            Console.WriteLine("The computer chose rock");
                            Console.WriteLine("You win. Paper beats rock");

                            score++;
                        }
                        else if (userChoice == "scissors")
                        {
                            Console.Clear();
                            Console.WriteLine("The computer chose paper");
                            Console.WriteLine("You win. Scissors beat paper");

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


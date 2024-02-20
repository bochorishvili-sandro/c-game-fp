using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Matcheasy
{
    internal interface Matchnormal
    {
        public static void RunGame()
        {
            int correctAnswers = 0;
            int wrongAnswers = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Math Quiz");


                Console.WriteLine("\nQuestion 1: What is 550 + 155?");
                Console.WriteLine("a) 700");
                Console.WriteLine("b) 705");
                Console.WriteLine("c) 695");
                Console.WriteLine("d) 789");
                Console.Write("Your answer: ");
                string answer1 = Console.ReadLine().ToLower();

                if (answer1 == "b")
                    correctAnswers++;
                else
                    wrongAnswers++;


                Console.WriteLine("\nQuestion 2: What is 550 % 2?");
                Console.WriteLine("a) 225");
                Console.WriteLine("b) 250");
                Console.WriteLine("c) 275");
                Console.WriteLine("d) 270");
                Console.Write("Your answer: ");
                string answer2 = Console.ReadLine().ToLower();

                if (answer2 == "c")
                    correctAnswers++;
                else
                    wrongAnswers++;


                Console.WriteLine("\nQuestion 3: What is 12 * 12?");
                Console.WriteLine("a) 121");
                Console.WriteLine("b) 169");
                Console.WriteLine("c) 124");
                Console.WriteLine("d) 144");
                Console.Write("Your answer: ");
                string answer3 = Console.ReadLine().ToLower();

                if (answer3 == "d")
                    correctAnswers++;
                else
                    wrongAnswers++;

                Console.WriteLine("\nQuestion 4: What is 123 * 0?");
                Console.WriteLine("a) 123");
                Console.WriteLine("b) 169");
                Console.WriteLine("c) 124");
                Console.WriteLine("d) 0");
                Console.Write("Your answer: ");
                string answer4 = Console.ReadLine().ToLower();

                if (answer4 == "d")
                    correctAnswers++;
                else
                    wrongAnswers++;


                Console.WriteLine($"\nResults: Correct Answers: {correctAnswers}, Wrong Answers: {wrongAnswers}");


                if (wrongAnswers > correctAnswers)
                {
                    Console.WriteLine("You have more wrong answers than correct ones. ");

                }
                if (wrongAnswers < correctAnswers)
                {
                    Console.WriteLine("you Won ");
                    break;
                }

                Console.WriteLine("\n try again ");
                string playAgain = Console.ReadLine();



                correctAnswers = 0;
                wrongAnswers = 0;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
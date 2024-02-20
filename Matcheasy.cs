using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Matcheasy
{
    internal interface Matcheasy
    {
        public static void RunGame()
        {
            int correctAnswers = 0;
            int wrongAnswers = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Math Quiz");

              
                Console.WriteLine("\nQuestion 1: What is 2 + 2?");
                Console.WriteLine("a) 3");
                Console.WriteLine("b) 4");
                Console.WriteLine("c) 5");
                Console.WriteLine("d) 6");
                Console.Write("Your answer: ");
                string answer1 = Console.ReadLine().ToLower();

                if (answer1 == "b")
                    correctAnswers++;
                else
                    wrongAnswers++;

               
                Console.WriteLine("\nQuestion 2: What is 10 - 5?");
                Console.WriteLine("a) 3");
                Console.WriteLine("b) 4");
                Console.WriteLine("c) 5");
                Console.WriteLine("d) 6");
                Console.Write("Your answer: ");
                string answer2 = Console.ReadLine().ToLower();

                if (answer2 == "c")
                    correctAnswers++;
                else
                    wrongAnswers++;

                
                Console.WriteLine("\nQuestion 3: What is 3 * 4?");
                Console.WriteLine("a) 9");
                Console.WriteLine("b) 10");
                Console.WriteLine("c) 11");
                Console.WriteLine("d) 12");
                Console.Write("Your answer: ");
                string answer3 = Console.ReadLine().ToLower();

                if (answer3 == "d")
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
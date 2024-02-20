using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MatchHard
{
    internal interface MatchHard
    {
        public static void RunGame()
        {
            int correctAnswers = 0;
            int wrongAnswers = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Math Quiz!");

              
                Console.WriteLine("\nQuestion 1: What is the square root of 144?");
                Console.WriteLine("a) 11");
                Console.WriteLine("b) 12");
                Console.WriteLine("c) 13");
                Console.WriteLine("d) 14");
                Console.Write("Your answer: ");
                string answer1 = Console.ReadLine().ToLower();

                if (answer1 == "b")
                    correctAnswers++;
                else
                    wrongAnswers++;

           
                Console.WriteLine("\nQuestion 2: What is the value of pi (π)?");
                Console.WriteLine("a) 3.12");
                Console.WriteLine("b) 3.14");
                Console.WriteLine("c) 3.16");
                Console.WriteLine("d) 3.18");
                Console.Write("Your answer: ");
                string answer2 = Console.ReadLine().ToLower();

                if (answer2 == "b")
                    correctAnswers++;
                else
                    wrongAnswers++;

             
                Console.WriteLine("\nQuestion 3: What is the result of 3^4?");
                Console.WriteLine("a) 72");
                Console.WriteLine("b) 81");
                Console.WriteLine("c) 84");
                Console.WriteLine("d) 85");
                Console.Write("Your answer: ");
                string answer3 = Console.ReadLine().ToLower();

                if (answer3 == "b")
                    correctAnswers++;
                else
                    wrongAnswers++;

                Console.WriteLine("\nQuestion 4: What is 123 * 123?");
                Console.WriteLine("a) 12349");
                Console.WriteLine("b) 15129");
                Console.WriteLine("c) 14329");
                Console.WriteLine("d) 14663");
                Console.Write("Your answer: ");
                string answer4 = Console.ReadLine().ToLower();

                if (answer4 == "b")
                    correctAnswers++;
                else
                    wrongAnswers++;

               
                Console.WriteLine("\nQuestion 5: What is the factorial of 5?");
                Console.WriteLine("a) 120");
                Console.WriteLine("b) 140");
                Console.WriteLine("c) 150");
                Console.WriteLine("d) 160");
                Console.Write("Your answer: ");
                string answer5 = Console.ReadLine().ToLower();

                if (answer5 == "a")
                    correctAnswers++;
                else
                    wrongAnswers++;

               
                Console.WriteLine($"\nResults: Correct Answers: {correctAnswers}, Wrong Answers: {wrongAnswers}");

              
            
                if (wrongAnswers < correctAnswers)
                {
                    Console.WriteLine("you win");
                    break;
                }

                Console.WriteLine("\n try again");
                string playAgain = Console.ReadLine().ToLower();
              

                correctAnswers = 0;
                wrongAnswers = 0;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}


 
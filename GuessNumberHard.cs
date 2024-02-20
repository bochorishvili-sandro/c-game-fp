﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fp_stuff2
{
    internal interface GuessNumberHard
    {
        public static void RunGuessNumber()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random random = new Random();
            int number = random.Next(0, 101);
            int trys = 3;
            List<int> Guesses = new List<int>();
            Console.WriteLine();
            Console.WriteLine("Guess Number");
            Console.WriteLine("-------------");
            Console.WriteLine("Try to guess the imagined number");
            Console.WriteLine("limit 0-100");
            Console.WriteLine("you have 3 lives");

            while (trys > 0)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                Console.WriteLine();
                int guess;

                if (int.TryParse(input, out guess))
                {
                    if (Guesses.Contains(guess))
                    {
                        Console.WriteLine($"You already guessed {guess}. Try a different number.");
                        trys++;

                    }

                    Guesses.Add(guess);

                    if (guess < number)
                    {
                        Console.WriteLine(" Try a higher number.");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine(" Try a lower number.");
                    }

                    else
                    {
                        Console.WriteLine("you win.");
                        
                        break;
                    }

                    trys--;
                    Console.WriteLine($"You have {trys} lives remaining.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine(" The secret number was: " + number);
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;

namespace WriteGameNormal
{
    public static class WriteGameNormal
    {
        private static List<string> sentences = new List<string>
        {
            "Hello my name is anton",
            "anton is very smart",
            "anton speaks english very well"
        };

        private static Random random = new Random();
        private static TimeSpan timeLimit = TimeSpan.FromSeconds(30);

        public static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Correction Game!");
            Console.WriteLine($"You have {timeLimit.TotalSeconds} seconds to correct each sentence.");
            Console.WriteLine("Let's begin!");
            int trys = 0;
            while (trys < 3)
            {
                DateTime startTime = DateTime.Now;
                string sentence = GetRandomSentence();
                Console.WriteLine("\nSentence to correct:");
                Console.WriteLine(sentence);

                Console.Write("Your corrected sentence: ");
                string playerInput = Console.ReadLine();

                TimeSpan elapsedTime = DateTime.Now - startTime;

                if (elapsedTime > timeLimit)
                {
                    Console.WriteLine($"Time's up! You took too long to correct the sentence.");
                    Console.WriteLine("Let's move on to the next one.");
                    continue;
                }

                if (IsCorrect(playerInput, sentence))
                {
                    Console.WriteLine($"Correct! You completed the sentence in {elapsedTime.TotalSeconds} seconds.");
                    trys++;
                }
                else
                {
                    Console.WriteLine("Incorrect! Let's try again.");
                }
            }
        }

        private static string GetRandomSentence()
        {
            int index = random.Next(sentences.Count);
            return sentences[index];
        }

        private static bool IsCorrect(string playerInput, string correctSentence)
        {
            return string.Equals(playerInput, correctSentence);
        }
    }
}
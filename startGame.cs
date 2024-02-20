using fp_stuff;
using fp_stuff2;
using Guess_number;
using Matcheasy;
using Rock;
using WriteGameEasy;



namespace startgame
{
    internal interface StartGame
    {
        public static void startGame()
        {
           Timer timer1 = new Timer();

            bool gameOne = false;
            bool gametwo = false;
            bool gamethree = false;
            bool gamefour = false;
            bool bigwhile = true;
           
            while (bigwhile)
                {

                
                Console.Clear();
                Console.WriteLine("Choose the Difficulty of the game");
                Console.WriteLine("1) easy");
                Console.WriteLine("2) normal");
                Console.WriteLine("3) hard");


                string difficulty = Console.ReadLine();
                if (difficulty != "1" && difficulty != "2" && difficulty != "3")
                {
                   
                        Console.WriteLine("please enter following number");
                    difficulty = Console.ReadLine();
                    
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("How fast can you beat the game");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("1) Guess the Number");
                    Console.WriteLine("2) How fast and correctly  type on the keyboard");
                    Console.WriteLine("3) Math Quiz");
                    Console.WriteLine("4) Rock, Paper, Scissors Game");
                    Console.WriteLine("5) Exit");

                    Console.WriteLine("Choose Number: 1-5");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            if (!gameOne)
                            {
                                if (difficulty == "1")
                                {
                                    Console.Clear();
                                    GuessNumberEasy.RunGuessNumber();
                                }
                                else if (difficulty == "2")
                                {
                                    Console.Clear();
                                    GuessNumberStart.RunGuessNumber();
                                }
                                else if (difficulty == "3")
                                {
                                    Console.Clear();
                                    GuessNumberHard.RunGuessNumber();
                                }
                              
                                gameOne = true;
                               
                            }
                            
                            break;

                        case "2":
                            if (!gametwo)
                            {
                                if (difficulty == "1")
                                {
                                    Console.Clear();
                                    WriteGameEasy.WriteGameHard.StartGame();
                                }
                                if (difficulty == "2")
                                {
                                    Console.Clear();
                                    WriteGameNormal.WriteGameNormal.StartGame();
                                }
                                if (difficulty == "3")
                                {
                                    Console.Clear();
                                    WriteGameHard.WriteGameHard.StartGame();

                                }
                                gametwo = true;
                                
                            }
                            break;
                          
                            break;

                        case "3":
                            if (!gamethree)
                            {
                                if (difficulty == "1")
                                {
                                    Console.Clear();
                                    Matcheasy.Matcheasy.RunGame();
                                }
                                if (difficulty == "2")
                                {
                                    Console.Clear();
                                    Matchnormal.RunGame();
                                }
                                if (difficulty == "3")
                                {
                                    Console.Clear();
                                   MatchHard.MatchHard.RunGame();
                                }
                                gamethree = true;

                            }
                            break;

                        case "4":
                            if (!gamefour)
                            {
                                if (difficulty == "1")
                                {
                                    Console.Clear();
                                    Rockeasy.RunGame();
                                }
                                if (difficulty == "2")
                                {
                                    Console.Clear();
                                    Rock2.Rocknormal.RunGame();
                                }
                                if (difficulty == "3")
                                {
                                    Console.Clear();
                                    Rock1.RockHard.RunGame();
                                }
                                gamefour = true;
                               
                            }
                            break;

                    }
                    if (input == "5")
                    {
                        if (gameOne == true && gametwo == true && gamefour ==true)
                        {
                            bigwhile = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("first beat all the games");
                        }
                    }

                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }
                }



                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            

        }
    }
}

    
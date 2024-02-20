using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using startgame;
class Program
{
    static Timer timer = new Timer();

    static void Main()
    {    bool TimerCheck = false;
        bool Finished = false;

        bool true2 = true;
        while (true2)
        {
            
            Console.Clear();
            Console.WriteLine("Press 'S' to start the timer, 'E' to end the timer, 'G' to start the game, and 'Q' to quit.");
            
            string key = Console.ReadLine();

            switch (key)
            {

                case "S":
                case "s":
                    timer.Start();
                    Console.WriteLine("press enter ");
                    TimerCheck = true;
                    Console.WriteLine( );
                    string enter = Console.ReadLine();
                    break;

                case "E":
                case "e":
                    timer.Stop();
                    Finished = false;
                    Console.WriteLine( );
                    Console.WriteLine("press enter");
                    string enter2 = Console.ReadLine();

                    break;

                case "G":
                case "g":
                    if (!Finished)
                    {  
                        if (TimerCheck)
                    {
                        startgame.StartGame.startGame();
                        Console.WriteLine();
                        Finished = true;
                    }
                    else
                    {
                        Console.WriteLine("start timer first");
                        Console.WriteLine("press enter ");
                        string enter3 = Console.ReadLine();
                    }

                        if (Finished ==true)
                        {
                            Console.WriteLine("you finished all games pls press e or E to save scores");
                            Console.WriteLine("press enter ");
                            string enter4 = Console.ReadLine();
                        }
                    }
                    break;

                case "Q":
                case "q":
                    true2 = false;
                    return;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Press 'S' to start, 'E' to end, 'G' to start the game, and 'Q' to quit.");
                    break;
            }
           
        }
    }
}
class Timer
{
    private DateTime startTime;
    private bool isRunning;
    private List<ScoreData> scores = new List<ScoreData>();

    public void Start()
    {

        if (!isRunning)
        {
            startTime = DateTime.Now;
            isRunning = true;
            Console.WriteLine("\nTimer started.");
        }
        else
        {
            Console.WriteLine("\nTimer is already running.");
        }
    }

    public void Stop()
    {
        if (isRunning)
        {
            TimeSpan GasuliDro = DateTime.Now - startTime;
            isRunning = false;
            Console.WriteLine($"\nTimer stopped.  time: {GasuliDro.TotalSeconds} seconds.");
            Console.Clear();

            Console.WriteLine($"\nTimer stopped.  time: {GasuliDro.TotalSeconds} seconds.");
            Console.WriteLine("Congratulations! You have completed all games.");
            Console.WriteLine($"Enter your username to save scores: {GasuliDro.TotalSeconds}");
            string username = Console.ReadLine();

            SaveScore(username, GasuliDro.TotalSeconds);
            DisplayTopScores();
        }
        else
        {
            Console.WriteLine("\nTimer is not running.");
        }
    }


    private void SaveScore(string username, double gasulidro)
    {
        Console.WriteLine("Enter the difficulty level at which you allready beat the game (1: Easy, 2: Normal, 3: Hard): ");
        int difficultyLevel = Convert.ToInt32(Console.ReadLine());
        scores.Add(new ScoreData { Username = username, Time = gasulidro, DifficultyLevel = difficultyLevel });
        scores = scores.OrderBy(s => s.Time).ThenBy(s => s.DifficultyLevel).ToList();
        string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(directoryPath, "scores.xml");

        XmlSerializer serializer = new XmlSerializer(typeof(List<ScoreData>));
        using (TextWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, scores);
        }

        Console.WriteLine("Score saved successfully.");
    }

    private void DisplayTopScores()
    {
        Console.WriteLine("\nTop Scores:");
        var groupedScores = scores.GroupBy(s => s.DifficultyLevel);
        foreach (var group in groupedScores)
        {
            Console.WriteLine($"\nDifficulty Level: {group.Key}");
            foreach (var score in group.Take(3)) 
            {
                Console.WriteLine($"Username: {score.Username}, Time: {score.Time} seconds");
            }
        }
    }
}


public class ScoreData
{
    public string Username { get; set; }
    public double Time { get; set; }
    public int DifficultyLevel { get; set; }
}
using System;

public class HighScoreSystem
{
    private static int highscore = 0;
    private static string highscorePlayer = "";

   
    public static void UpdateHighScore(int score, string playerName)
    {
        if (score > highscore)
        {
            highscore = score;
            highscorePlayer = playerName;
            Console.WriteLine("New highscore is " + score);
            Console.WriteLine("New highscore holder is " + playerName);
        }
        else
        {
            Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
        }
    }

    public static void Main(string[] args)
    {
        
        highscore = 100;
        highscorePlayer = "John";

       
        UpdateHighScore(150, "Alice");
    }
}

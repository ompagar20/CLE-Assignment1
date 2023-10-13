using System;

public class AverageScoreCalculator
{
    public static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;

        Console.WriteLine("Enter individual scores (between 0 and 20). Enter -1 to calculate average.");

        while (true)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int score))
            {
                if (score == -1)
                {
                    if (count == 0)
                    {
                        Console.WriteLine("No scores entered. Cannot calculate average.");
                    }
                    else
                    {
                        double average = (double)sum / count;
                        Console.WriteLine("Average score: " + average);
                    }
                    break;
                }

                if (score >= 0 && score <= 20)
                {
                    sum += score;
                    count++;
                }
                else
                {
                    Console.WriteLine("Score should be between 0 and 20.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid score.");
            }
        }
    }
}

using System;

public class LoopsExample
{
    public static void ForLoop()
    {
        Console.WriteLine("Using For Loop:");
        for (int i = -3; i <= 3; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void WhileLoop()
    {
        Console.WriteLine("Using While Loop:");
        int j = 3;
        while (j >= -3)
        {
            Console.WriteLine(j);
            j--;
        }
    }

    public static void Main(string[] args)
    {
        ForLoop();
        Console.WriteLine();  
        WhileLoop();
    }
}

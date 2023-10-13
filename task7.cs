using System;

public class Program
{
   
    public static void Check(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }

    public static void Run()
    {
        
        int testNumber1 = 7;
        int testNumber2 = 10;

        
        Console.WriteLine("Checking number " + testNumber1 + ":");
        Check(testNumber1);

        Console.WriteLine("Checking number " + testNumber2 + ":");
        Check(testNumber2);
    }

    public static void Main(string[] args)
    {
       
        Run();
    }
}

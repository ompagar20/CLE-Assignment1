using System;

public class Program
{
    
    public static string LowUpper(string input)
    {
        string lowerCase = input.ToLower();
        string upperCase = input.ToUpper();
        return input + lowerCase + upperCase;
    }

    
    public static void Count(string input)
    {
        int charCount = input.Length;
        Console.WriteLine("The amount of characters is " + charCount + ".");
    }

    public static void Run()
    {
        string defaultString = "hey there !";
        
        
        string result = LowUpper(defaultString);
        Console.WriteLine(result);

        
        Count(defaultString);
    }

    public static void Main(string[] args)
    {
       
        Run();
    }
}

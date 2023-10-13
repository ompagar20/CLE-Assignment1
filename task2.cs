using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        string userInput;

        Console.WriteLine("Please enter your name and press enter: ");
        userInput = Console.ReadLine();

       
        Console.WriteLine("Uppercase: " + userInput.ToUpper());

       
        Console.WriteLine("Lowercase: " + userInput.ToLower());

        
        string trimmedString = userInput.Replace(" ", "");
        Console.WriteLine("String with no spaces: " + trimmedString);

        
        Console.WriteLine("Substring: " + userInput.Substring(1));
    }
}

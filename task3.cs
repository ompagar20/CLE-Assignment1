using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Console.Write("Enter a string here: ");
        string userString = Console.ReadLine();

       
        Console.Write("Enter the character to search: ");
        char searchChar = Console.ReadKey().KeyChar;

        
        int indexOfChar = userString.IndexOf(searchChar);
        Console.WriteLine($"\nIndex of '{searchChar}' in the string: {indexOfChar}");

       
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

       
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        
        string fullName = $"{firstName} {lastName}";

       
        Console.WriteLine($"Full Name: {fullName}");
    }
}

using System;

public class Program
{
    public static void Main(string[] args)
    {
       
        int integerVariable = 42;
        double doubleVariable = 3.14;
        char charVariable = 'A';
        bool boolVariable = true;

       
        string string1 = "I control text";
        string string2 = "123"; 

       
        int parsedInteger;
        if (int.TryParse(string2, out parsedInteger))
        {
            Console.WriteLine("Successfully parsed string2 to an integer: " + parsedInteger);
        }
        else
        {
            Console.WriteLine("Failed to parse string2 to an integer.");
        }

      
        Console.WriteLine("Integer Variable: " + integerVariable);
        Console.WriteLine("Double Variable: " + doubleVariable);
        Console.WriteLine("Char Variable: " + charVariable);
        Console.WriteLine("Boolean Variable: " + boolVariable);
        Console.WriteLine("String 1: " + string1);
        Console.WriteLine("String 2: " + string2);
    }
}

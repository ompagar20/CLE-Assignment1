using System;

public class TemperatureChecker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the temperature: ");
        string inputTemperature = Console.ReadLine();

        
        bool isValidInteger = int.TryParse(inputTemperature, out int temperature);

       
        string result = isValidInteger
            ? (temperature <= 15 ? "It is too cold here" :
               temperature >= 16 && temperature <= 28 ? "It is ok" :
               "It is hot here")
            : "Not a valid temperature";

        Console.WriteLine(result);
    }
}

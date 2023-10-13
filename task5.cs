using System;

public class Program
{
   
    public static void GreetFriend(string friendName)
    {
        Console.WriteLine("Hi " + friendName + ", my friend!");
    }

    public static void Main(string[] args)
    {
        
        string friend1 = "Alice";
        string friend2 = "Bob";
        string friend3 = "Charlie";

      
        GreetFriend(friend1);
        GreetFriend(friend2);
        GreetFriend(friend3);
    }
}

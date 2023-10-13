using System;

public class UserLoginSystem
{
    private string username;
    private string password;

    
    public void Register()
    {
        Console.WriteLine("Registration:");

        Console.Write("Enter a username: ");
        username = Console.ReadLine();

        Console.Write("Enter a password: ");
        password = Console.ReadLine();

        Console.WriteLine("Registration successful!\n");
    }

   
    public void Login()
    {
        Console.WriteLine("Login:");

        Console.Write("Enter your username: ");
        string inputUsername = Console.ReadLine();

        Console.Write("Enter your password: ");
        string inputPassword = Console.ReadLine();

        if (inputUsername == username && inputPassword == password)
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Login failed. Invalid username or password.");
        }
    }

    public static void Main(string[] args)
    {
        UserLoginSystem loginSystem = new UserLoginSystem();

       
        loginSystem.Register();

       
        loginSystem.Login();
    }
}

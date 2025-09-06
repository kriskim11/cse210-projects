using System;

class Program
{
    static string DisplayWelcom()
    {
        Console.Write("Welcome to the program!");
        return Console.ReadLine();
    }

    static string PromptUserName()
    {
        Console.Write("What is your name full? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void Main(string[] args)
    {
        string message = DisplayWelcom();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squared = SquareNumber(favoriteNumber);
    
        Console.WriteLine($"{message}");
        Console.WriteLine($"Hello,{name}! Your favorite number is {favoriteNumber}.");
        Console.WriteLine($"{name} The square of your favorite number is {squared}.");
    } 
}

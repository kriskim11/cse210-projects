using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your first name?");
        Console.WriteLine("what is your last name?");

        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is  {firstName} {lastName}");
        
    }
}
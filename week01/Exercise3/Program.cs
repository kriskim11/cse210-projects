using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("guess a number between 1 and 20");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        Random random = new Random();
        int randomNumber = random.Next(1, 21);
        while (number != randomNumber)
        {
            if (number < randomNumber)
            {
                Console.WriteLine("too low, try again");
            }
            else
            {
                Console.WriteLine("too high, try again");
            }
            input = Console.ReadLine();
            number = int.Parse(input);
        }
        Console.WriteLine("you guessed it!");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1,200);
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("guess a number betweeen 1 and 200");
            guess = int.Parse(Console.ReadLine());
            
            if (magicNumber>guess){
                Console.WriteLine("higher");

            }
            else if (magicNumber < guess){
                Console.WriteLine("lower");
            }
            else 
            {
                Console.WriteLine("you guessed the magic number!!!");
            }
        }
        


    }
}
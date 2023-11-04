using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessaage();

        string userName = EnterName();
        int userNumber = GetNumber();
        int squareNumber = SquareNumber(userNumber);

        Result(userName,squareNumber);

    
        static void WelcomeMessaage()
        {
            Console.WriteLine("welcome ot the program");
        }
        static string EnterName()
        {
            Console.Write("please enter your name:");
            string name = Console.ReadLine();
            return name;
        }
        static int GetNumber()
        {
            Console.Write("please enter your favorite number:");
            int number = int.Parse(Console.ReadLine());
            return number;

        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void Result(string name, int square)
        {
            Console.WriteLine($"{name},the square of your number is {square}");
        }
    }
}
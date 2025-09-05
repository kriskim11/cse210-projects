using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is you grade point average?");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        if (grade >= 90)
        {
            Console.WriteLine("Congratulations you got a A!");
        }
         else if (grade >= 80)
        {
            Console.WriteLine("Congratulations you got a B!");
        }
         else if (grade >= 70)
        {
            Console.WriteLine("Congratulations you got a C!");
        }

        else if (grade >= 60)
        {
            Console.WriteLine("Congratulations you got a D!");
        }

        else
        {
            Console.WriteLine("Unfortunately, you got an F.");
        }
        
    }
}
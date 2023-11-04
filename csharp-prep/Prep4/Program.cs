using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int UserNumber = -0;
        while (UserNumber !=0){
            Console.Write("Enter a number (0 to quit):");
            string userResponse = Console.ReadLine();
            UserNumber = int.Parse(userResponse);

            if(UserNumber !=0){
                numbers.Add(UserNumber);
            }
    
        }

        int sum = 0;
        foreach(int number in numbers){
            sum += number;
        }

        Console.WriteLine($"the sum is: {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is:{average}");

        int maximum = numbers[0];

        foreach (int number in numbers){
            if(number>maximum){
                maximum = number;
            }
        }

        Console.WriteLine($"the max is: {maximum}");
    }
}
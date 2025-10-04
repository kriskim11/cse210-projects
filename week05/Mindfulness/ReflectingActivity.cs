using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a challenge.",
        "Recall a moment when you helped someone in need.",
        "Remember a time when you achieved a personal goal.",
    
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?",
    };

    public ReflectingActivity()
    {
        _activityName = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        // Choose a random prompt
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        Console.WriteLine("How did this experience make you feel when it was complete?");
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        int questionIndex = 0;
        while (DateTime.Now < endTime && questionIndex < _questions.Count)
        {
            Console.WriteLine($"> {_questions[questionIndex]}");
            ShowSpinner(5); 
            questionIndex++;
        }

        DisplayEndingMessage();
        ShowSpinner(3);
    }
}
using System.Threading;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration; 
    public Activity()
    {
        _activityName = "Mindfulness Activity";
        _description = "This is the mindfulness activity.";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}!");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How many seconds would you like to do this activity? ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_activityName} for {_duration} seconds.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    public int GetDuration()
    {
        string input = Console.ReadLine();
        while (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            Console.Write("how many seconds would you like to do this activity?: ");
            input = Console.ReadLine();
        }
        return _duration;
    }

    // Showing spinner animation 
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int spin = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spin % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            spin++;
        }
    }

    // Showing countdown in seconds 
    public void ShowCountdown(int seconds)
    {
        for (int countdown = seconds; countdown > 0; countdown--)
        {
            Console.Write(countdown);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
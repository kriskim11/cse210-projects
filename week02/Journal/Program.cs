using System;

class Program
{
    static void Main(string[] args)
    {   // creates instances of Journal and PromptGen
        Journal journal = new Journal();
        PromptGen promptGen = new PromptGen();

        bool running = true; // main menu loop
        while (running)
        {
            Console.WriteLine("\nPlease select the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            //user menu choice handling 
            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Entry entry = new Entry(prompt, response, DateTime.Now.ToString());
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-5.");
                    break;
            }
        }
    }
}
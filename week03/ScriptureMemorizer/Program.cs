using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference 
        Reference reference = new Reference("Mosiah", 2,17,17);

        /*Console.WriteLine(reference.Book);
        reference.Book = "Mosiah";
        reference.Chapter = 2;
        reference.StartVerse = 17;
        reference.EndVerse = 17;
        */

        // The scripture text
        string scriptureText = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";

    
        Scripture scripture = new Scripture(reference, scriptureText);

        // making a loop
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            scripture.HideRandomWords(1);
        }

        Console.WriteLine("All words are hidden good job!");
    }
}
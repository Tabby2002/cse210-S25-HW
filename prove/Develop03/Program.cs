using System;


class Program
{
    static void Main()
    {
        // Takes scripture reference and renames as a string called text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        // Shows the scripture with some words hidden and asks usar whether or not to quit
        while (!scripture.AllHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideWords();
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Great job!");
    }
}
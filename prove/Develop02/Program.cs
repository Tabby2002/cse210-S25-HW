// This is the main program. Calls Entry when 1 is typed. Calls Jounal when 2-4 is typed.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
                journal.WriteEntry();
            else if (choice == "2")
                journal.DisplayEntries();
            else if (choice == "3")
            {
                Console.Write("Filename (example.txt): ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == "4")
            {
                Console.Write("Filename (same as saved): ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == "5")
            {
                Console.Write("Goodbye.");
            }
            else
            {
            Console.WriteLine("Invalid option. Please choose 1–5.");
            }
        }
    }
}
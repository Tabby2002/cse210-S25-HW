// Jounal: This program tells the user to enter the date, gives a random prompt, and display-save-load said enteries.

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Creates a List of each journal prompts
    public List<Entry> entries = new List<Entry>();
    public List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    // When a '1' is typed it grabs a random prompt, asks for date, displays prompt for response, and adds each piece to entry.
    public void WriteEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];

        Console.WriteLine("Enter the date (MM-DD-YYYY):");
        string date = Console.ReadLine();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry();
        entry.Date = date;
        entry.Prompt = prompt;
        entry.Response = response;

        entries.Add(entry);
    }

    // Displays entry when '2' is typed
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    // Saves entry when '3' is typed
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
    }

    // Loads entry when '4' is typed
    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            entries.Add(Entry.FromFileString(lines));
        }
    }
}
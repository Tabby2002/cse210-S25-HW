using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    }
}

public string ToFileString()
    {
        return $"Date: {Date}\n Prompt: {Prompt}\n Response: {Response}\n---";
    }

    // This makes a journal entry from 3 lines of text by removing the labels and just saving the values so everything is one entry.
    public static Entry FromFileString(string[] lines)
    {
        Entry entry = new Entry();
        entry.Date = lines[0].Substring("Date: ".Length);
        entry.Prompt = lines[1].Substring("Prompt: ".Length);
        entry.Response = lines[2].Substring("Response: ".Length);
        return entry;
    }


public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        Entry entry = new Entry();
        entry.Date = parts[0];
        entry.Prompt = parts[1];
        entry.Response = parts[2];
        return entry;
    }
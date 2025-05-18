// Entry; This program puts each part of the jounal entry together.

using System;

public class Entry
{
    public string Date;
    public string Prompt;
    public string Response;

    // Structure of entry when asked to display
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}\n");
    }

    // Structure of new file, making each part have their own line.
    public string ToFileString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n---";
    }

    public static Entry FromFileString(string[] lines)
    {
        Entry entry = new Entry();
        entry.Date = lines[0].Substring("Date: ".Length);
        entry.Prompt = lines[1].Substring("Prompt: ".Length);
        entry.Response = lines[2].Substring("Response: ".Length);
        return entry;
    }
}
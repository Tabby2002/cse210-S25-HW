using System.Reflection.Metadata.Ecma335;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
       return _duration;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine($"{_description}");
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(1000);
        
    }

    public void EndMessage()
    {
        Console.WriteLine("\nGood job!");
        Console.WriteLine($"You completed {_duration} seconds of {_name}.");
        
    }
    
    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

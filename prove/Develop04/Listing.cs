class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "When have you felt peace this week?"
    };

    public void Run()
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life.");
        StartMessage();

        Random rand = new Random();
        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("Start listing (press Enter after each item):");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items.");
        EndMessage();
    }
}

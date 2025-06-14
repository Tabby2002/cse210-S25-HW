
class ReflectionActivity : Activity

{
    private List<string> _prompts = new List<string> {
        "Think of a time you stood up for someone else.",
        "Think of a time you did something difficult.",
        "Think of a time you helped someone in need.",
        "Think of a time you did something selfless."
    };

    private List<string> _questions = new List<string> {
        "Why was this meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from it?"
    };

    public void Run()
    {
        SetName("Reflection");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
        StartMessage();

        Random rand = new Random();
        Console.WriteLine("\nPrompt:");
        Console.WriteLine($"→ {_prompts[rand.Next(_prompts.Count)]}");
        Console.WriteLine("\nReflect on this for a moment...");
        

        int timeLeft = GetDuration();

        while (timeLeft > 0)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"\n→ {question}");
            
            timeLeft -= 4;
        }

        EndMessage();
    }
}

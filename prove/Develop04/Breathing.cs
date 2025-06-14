class BreathingActivity : Activity
{
    public void Run()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax through slow breathing. Clear your mind and focus on your breath.");
        StartMessage();

        int timeLeft = GetDuration();
        while (timeLeft > 0)
        {
            Console.Write("Breathe in... ");
            Countdown(3);
            timeLeft -= 3;

            if (timeLeft <= 0) break;

            Console.Write("Breathe out... ");
            Countdown(3);
            timeLeft -= 3;
        }
        EndMessage();
    }
}
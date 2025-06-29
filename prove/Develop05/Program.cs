using System;

class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine($"\nScore: {score}");
            Console.WriteLine("1. Add Goal\n2. List Goals\n3. Record Event\n4. Quit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Goal type (simple/eternal/checklist): ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "simple")
                    goals.Add(new SimpleGoal(name, points));
                else if (type == "eternal")
                    goals.Add(new EternalGoal(name, points));
                else if (type == "checklist")
                {
                    Console.Write("Times to complete: ");
                    int times = int.Parse(Console.ReadLine());
                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, points, times, bonus));
                }
            }
            else if (choice == "2")
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].GetName()}");
                }
            }
            else if (choice == "3")
            {
                Console.Write("Which goal number? ");
                int index = int.Parse(Console.ReadLine()) - 1;
                int pts = goals[index].RecordEvent();
                Console.WriteLine($"You earned {pts} points!");
                score += pts;
            }
            else if (choice == "4")
            {
                running = false;
            }
        }
    }
}

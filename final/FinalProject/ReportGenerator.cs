// Generates a monthly financial report summarizing income, expenses, and savings.
public class ReportGenerator
{
    public void GenerateMonthlyReport(UserProfile user)
    {
        Console.WriteLine($"\n--- Monthly Report for {user.GetName()} ---");
        Console.WriteLine($"Total Income: {user.TotalIncome():C}");
        Console.WriteLine($"Total Expenses: {user.TotalExpenses():C}");

        if (user.GetBudget().IsOverBudget(user.TotalExpenses()))
        {
            Console.WriteLine("Warning: You are over budget!");
        }
        else
        {
            Console.WriteLine("You are within your budget.");
        }

        Console.WriteLine($"Savings Progress: {user.GetSavingsGoal().GetProgress():F2}%\n");
    }
}


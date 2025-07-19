// Generates a monthly financial report summarizing income, expenses, and savings.
public class ReportGenerator
{
    public void GenerateMonthlyReport(UserProfile user)
    {
        Console.WriteLine($"\n--- Monthly Report for {user.Name} ---");
        Console.WriteLine($"Total Income: {user.TotalIncome():C}");
        Console.WriteLine($"Total Expenses: {user.TotalExpenses():C}");
        Console.WriteLine(user.Budget.IsOverBudget(user.TotalExpenses()) 
            ? "Warning: You are over budget!" 
            : "You are within your budget.");
        Console.WriteLine($"Savings Progress: {user.SavingsGoal.Progress:F2}%\n");
    }
}

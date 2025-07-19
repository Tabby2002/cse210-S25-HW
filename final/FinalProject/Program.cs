using System;
// Entry point of the application that creates a user, adds transactions, and displays a report.

public class Program
{
    public static void Main()
    {
        UserProfile user = new UserProfile
        {
            Name = "Tabitha",
            Budget = new Budget(1000m),
            SavingsGoal = new SavingsGoal(500m)
        };

        user.AddTransaction(new Income(1500m, DateTime.Now, "Paycheck"));
        user.AddTransaction(new Expense(200m, DateTime.Now, "Groceries"));
        user.AddTransaction(new Expense(300m, DateTime.Now, "Utilities"));
        user.SavingsGoal.AddToSavings(200m);

        ReportGenerator reportGen = new ReportGenerator();
        reportGen.GenerateMonthlyReport(user);
    }
}
// Inherits from Transaction and represents money spent.
using System.Transactions;

public class Expense : Transaction
{
    public Expense(decimal amount, DateTime date, string category)
        : base(amount, date, category) {}

    public override string GetSummary()
    {
        return $"Expense: {GetAmount():C} on {GetDate().ToShortDateString()} in {GetCategory()}";
    }
}
// Inherits from Transaction and represents money received.
using System.Transactions;

public class Income : Transaction
{
    public Income(decimal amount, DateTime date, string category)
        : base(amount, date, category)
    { 
    }

    public override string GetSummary()
    {
        return $"Income: {Amount:C} on {Date.ToShortDateString()} in {Category}";
    }
}
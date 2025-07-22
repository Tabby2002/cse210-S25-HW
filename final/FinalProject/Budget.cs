// Manages the user's monthly spending limit and checks if it's exceeded.
public class Budget
{
    private decimal _monthlyLimit;

    public Budget(decimal limit)
    {
        _monthlyLimit = limit;
    }

    public decimal GetMonthlyLimit()
    {
        return _monthlyLimit;
    }

    public void SetMonthlyLimit(decimal limit)
    {
        _monthlyLimit = limit;
    }

    public bool IsOverBudget(decimal totalExpenses)
    {
        return totalExpenses > _monthlyLimit;
    }
}

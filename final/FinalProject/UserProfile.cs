// Stores the user's name, transactions, budget, and savings goal.
public class UserProfile
{
    private List<Transaction> _transactions = new();
    private string _name;
    private Budget _budget;
    private SavingsGoal _savingsGoal;

    public List<Transaction> GetAllTransactions()
    {
        return _transactions;
    }

    public void AddTransaction(Transaction t)
    {
        _transactions.Add(t);
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public Budget GetBudget()
    {
        return _budget;
    }

    public void SetBudget(Budget budget)
    {
        _budget = budget;
    }

    public SavingsGoal GetSavingsGoal()
    {
        return _savingsGoal;
    }

    public void SetSavingsGoal(SavingsGoal savingsGoal)
    {
        _savingsGoal = savingsGoal;
    }

    public decimal TotalExpenses()
    {
        decimal total = 0;
        foreach (var transaction in _transactions)
        {
            if (transaction is Expense expense)
            {
                total += expense.GetAmount();
            }
        }
        return total;
    }

    public decimal TotalIncome()
    {
        decimal total = 0;
        foreach (var transaction in _transactions)
        {
            if (transaction is Income income)
            {
                total += income.GetAmount();
            }
        }
        return total;
    }
}

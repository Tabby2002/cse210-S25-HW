// Stores the user's name, transactions, budget, and savings goal.
public class UserProfile
{
    private List<Transaction> transactions = new();
    public List<Transaction> GetAllTransactions() => transactions;
    private string _name;
    private Budget _budget;
    private SavingsGoal _savingsGoal;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }   
    
    public Budget Budget
    {
    get { return _budget; }
    set { _budget = value; }
    }
    public SavingsGoal SavingsGoal
    {
    get { return _savingsGoal; }
    set { _savingsGoal = value; }
    }

    public void AddTransaction(Transaction t)
    {
        transactions.Add(t);
    }

    public decimal TotalExpenses()
    {
    decimal total = 0;
    foreach (var transaction in transactions)
    {
        if (transaction is Expense expense)
        {
            total += expense.Amount;
        }
    }
    return total;
    }

    public decimal TotalIncome()
    {
    decimal total = 0;
    foreach (var transaction in transactions)
    {
        if (transaction is Income income)
        {
            total += income.Amount;
        }
    }
    return total;
    }
}
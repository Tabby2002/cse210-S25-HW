// Represents a financial transaction (income or expense) with common properties.
public abstract class Transaction
{
    private decimal _amount;
    private DateTime _date;
    private string _category;

    public Transaction(decimal amount, DateTime date, string category)
    {
        _amount = amount;
        _date = date;
        _category = category;
    }

    public decimal Amount => _amount;
     
    public DateTime Date => _date;
    public string Category => _category;
    public abstract string GetSummary();
}
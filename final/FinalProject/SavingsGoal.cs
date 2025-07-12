// Tracks the user's progress toward a savings goal.
public class SavingsGoal
{
    private decimal _goalAmount;
    private decimal _currentSavings;

    public SavingsGoal(decimal goalAmount)
    {
        _goalAmount = goalAmount;
        _currentSavings = 0;
    }

    public void AddToSavings(decimal amount)
    {
        _currentSavings += amount;
    }

    public bool GoalMet()
    {
        return _currentSavings >= _goalAmount;
    }

    public decimal Progress => (_currentSavings / _goalAmount) * 100;
}
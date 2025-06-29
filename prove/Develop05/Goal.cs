public abstract class Goal
{
    protected string _name;
    protected int _points;

    public string GetName()
    {
    return _name;
    }

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
}

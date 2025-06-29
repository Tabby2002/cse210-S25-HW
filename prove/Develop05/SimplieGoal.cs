public class SimpleGoal : Goal
{
    private bool _complete = false;

    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        if (!_complete)
        {
            _complete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _complete;

    public override string GetStatus() => _complete ? "[X]" : "[~]";
}

public class ChecklistGoal : Goal
{
    private int _timesDone = 0;
    private int _timesNeeded;
    private int _bonus;

    public ChecklistGoal(string name, int points, int timesNeeded, int bonus)
        : base(name, points)
    {
        _timesNeeded = timesNeeded;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_timesDone < _timesNeeded)
        {
            _timesDone++;
            int total = _points;
            if (_timesDone == _timesNeeded) total += _bonus;
            return total;
        }
        return 0;
    }

    public override bool IsComplete() => _timesDone >= _timesNeeded;

    public override string GetStatus() =>
        $"[{(_timesDone >= _timesNeeded ? "X" : "~")}] {_timesDone}/{_timesNeeded}";
}

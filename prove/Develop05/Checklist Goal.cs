public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, int points, int targetCount, int bonus) : base(name, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted >= _targetCount && !IsComplete)
        {
            IsComplete = true;
            return Points + _bonus;
        }
        return Points;
    }

    public override string GetStatus()
    {
        return IsComplete ? $"[X] {Name} Completed {_timesCompleted}/{_targetCount}" :
                            $"[ ] {Name} Completed {_timesCompleted}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Points},{_timesCompleted},{_targetCount},{_bonus},{IsComplete}";
    }
}
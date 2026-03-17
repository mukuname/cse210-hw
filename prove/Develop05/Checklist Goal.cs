public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points,
                         int targetCount, int bonusPoints, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _currentCount++;
        int total = Points;

        if (_currentCount == _targetCount)
        {
            total += _bonusPoints;
        }

        return total;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatusString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {Name} ({Description}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        // ChecklistGoal|name|description|points|target|bonus|current
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_bonusPoints}|{_currentCount}";
    }

    public static ChecklistGoal FromData(string[] parts)
    {
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        int target = int.Parse(parts[4]);
        int bonus = int.Parse(parts[5]);
        int current = int.Parse(parts[6]);
        return new ChecklistGoal(name, description, points, target, bonus, current);
    }
}
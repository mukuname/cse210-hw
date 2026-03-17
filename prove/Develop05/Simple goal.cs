public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0; // already completed
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatusString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {Name} ({Description})";
    }

    public override string GetSaveString()
    {
        // SimpleGoal|name|description|points|isComplete
        return $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
    }

    public static SimpleGoal FromData(string[] parts)
    {
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        bool isComplete = bool.Parse(parts[4]);
        return new SimpleGoal(name, description, points, isComplete);
    }
}
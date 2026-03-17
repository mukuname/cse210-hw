public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // never complete, always award points
        return Points;
    }

    public override bool IsComplete() => false;

    public override string GetStatusString()
    {
        return $"[∞] {Name} ({Description})";
    }

    public override string GetSaveString()
    {
        // EternalGoal|name|description|points
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }

    public static EternalGoal FromData(string[] parts)
    {
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        return new EternalGoal(name, description, points);
    }
}
public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public string Name => _name;
    public string Description => _description;
    public int Points => _points;

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();          // returns points earned
    public abstract bool IsComplete();
    public abstract string GetStatusString();   // e.g. "[X] Read scriptures"
    public abstract string GetSaveString();     // for saving to file

    // Optional: factory helper for loading
    public static Goal FromSaveString(string line)
    {
        // format: Type|name|description|points|extra...
        string[] parts = line.Split('|');
        string type = parts[0];

        switch (type)
        {
            case "SimpleGoal":
                return SimpleGoal.FromData(parts);
            case "EternalGoal":
                return EternalGoal.FromData(parts);
            case "ChecklistGoal":
                return ChecklistGoal.FromData(parts);
            default:
                throw new Exception("Unknown goal type");
        }
    }
}
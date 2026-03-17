public abstract class Goal
{
    private string _name;
    private int _points;
    private bool _isComplete;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    public string Name { get => _name; }
    public int Points { get => _points; }
    public bool IsComplete { get => _isComplete; protected set => _isComplete = value; }

    // Record progress for the goal
    public abstract int RecordEvent();

    // String representation for displaying the goal
    public abstract string GetStatus();

    // Used for saving/loading
    public abstract string GetStringRepresentation();
}
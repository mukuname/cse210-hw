using System;

public class Running : Activity
{
    private double _distance; // miles

    public Running(string date, int length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / GetLength()) * 60; // mph

    public override double GetPace() => GetLength() / _distance; // min per mile
}
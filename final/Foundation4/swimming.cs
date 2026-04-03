using System;

public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50;

    public Swimming(string date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    // Convert meters to miles (1 m = 0.000621371 mi)
    public override double GetDistance() => _laps * LapLengthMeters * 0.000621371;

    public override double GetSpeed() => (GetDistance() / GetLength()) * 60; // mph

    public override double GetPace() => GetLength() / GetDistance(); // min per mile
}
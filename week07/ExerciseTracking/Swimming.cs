using System;
using FitnessTrackerApp;

class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50;
    private const double MetersToMiles = 0.000621371;

    public int Laps
    {
        get { return _laps; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Laps cannot be negative.");
            _laps = value;
        }
    }

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * LapLengthMeters * MetersToMiles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }
}
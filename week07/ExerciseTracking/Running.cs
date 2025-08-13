using System;
using FitnessTrackerApp;

class Running : Activity
{
    private double _distance;

    public double Distance
    {
        get { return _distance; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Distance must be positive.");
            _distance = value;
        }
    }

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / Distance;
    }
}
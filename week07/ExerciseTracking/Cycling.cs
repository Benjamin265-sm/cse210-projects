using System;
using FitnessTrackerApp;

class Cycling : Activity
{
    private double _speed;

    public double Speed
    {
        get { return _speed; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Speed must be positive.");
            _speed = value;
        }
    }

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        // Distance = speed * hours
        return Speed * (LengthInMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return LengthInMinutes / distance;
    }
}
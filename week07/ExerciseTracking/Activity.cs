using System;
using System.Globalization;

namespace FitnessTrackerApp
{
    abstract class Activity
    {
        private DateTime _date;
        private int _lengthInMinutes;

        public DateTime Date
        {
            get { return _date; }
            private set { _date = value; }
        }

        public int LengthInMinutes
        {
            get { return _lengthInMinutes; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Length in minutes must be positive.");
                _lengthInMinutes = value;
            }
        }

        protected Activity(DateTime date, int lengthInMinutes)
        {
            Date = date;
            LengthInMinutes = lengthInMinutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            string dateStr = Date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
            string activityType = this.GetType().Name;
            double distance = Math.Round(GetDistance(), 1);
            double speed = Math.Round(GetSpeed(), 1);
            double pace = Math.Round(GetPace(), 2);

            return $"{dateStr} {activityType} ({LengthInMinutes} min) - Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
        }
    }
}
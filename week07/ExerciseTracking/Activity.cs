using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        public DateTime Date { get; set; }
        public int Minutes { get; set; }

        public Activity(DateTime date, int minutes)
        {
            Date = date;
            Minutes = minutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return $"{Date:dd MMM yyyy} {GetType().Name} ({Minutes} min) - Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
        }
    }
}

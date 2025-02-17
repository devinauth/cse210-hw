namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        public int Laps { get; set; }

        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            Laps = laps;
        }

        public override double GetDistance()
        {
            return (Laps * 50) / 1000.0; // Distance in km (50 meters per lap)
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60; // Speed in kph
        }

        public override double GetPace()
        {
            return Minutes / GetDistance(); // Pace in min per km
        }
    }
}

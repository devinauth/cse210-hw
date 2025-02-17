namespace ExerciseTracking
{
    public class Running : Activity
    {
        public double Distance { get; set; }

        public Running(DateTime date, int minutes, double distance) : base(date, minutes)
        {
            Distance = distance;
        }

        public override double GetDistance()
        {
            return Distance;
        }

        public override double GetSpeed()
        {
            return (Distance / Minutes) * 60; // Speed in kph
        }

        public override double GetPace()
        {
            return Minutes / Distance; // Pace in min per km
        }
    }
}

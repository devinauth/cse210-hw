namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        public double Speed { get; set; }

        public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
        {
            Speed = speed;
        }

        public override double GetDistance()
        {
            return (Speed * Minutes) / 60; // Distance in km
        }

        public override double GetSpeed()
        {
            return Speed;
        }

        public override double GetPace()
        {
            return 60 / Speed; // Pace in min per km
        }
    }
}

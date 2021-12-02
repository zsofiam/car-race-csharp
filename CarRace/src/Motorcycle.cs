using CarRace.src.Util;


namespace CarRace.src
{
    public class Motorcycle : Vehicle
    {
        public const int NORMAL_SPEED = 100;
        private static int _motorcycleNumber = 1;

        public Motorcycle() : base(NORMAL_SPEED)
        {
        }

        protected override string GenerateName()
        {
            return "Motorcycle " + _motorcycleNumber++;
        }
        public override void PrepareForLap(Race race)
        {
            ActualSpeed = NORMAL_SPEED;

            if (race.IsRaining)
            {
                int slowDown = RandomHelper.NextInt(5, 50 + 1);
                ActualSpeed -= slowDown;
            }
        }
    }
}
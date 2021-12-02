using CarRace.src.Util;


namespace CarRace.src
{
    public class Car : Vehicle
    {
        private static readonly string[] POSSIBLE_NAMES =
    {
        "Epiphany",
        "Parallel",
        "Blitz",
        "Eos",
        "Evolution",
        "Wolf",
        "Union",
        "Empyrean",
        "Curiosity",
        "Gallop",
    };
        protected const int YELLOW_FLAG_SPEED = 75;
        public Car() : base(CalculateNormalSpeed())
        {
        }
        private static int CalculateNormalSpeed()
        {
            return RandomHelper.NextInt(80, 110 + 1);
        }
        protected override string GenerateName()
        {
            string firstName = RandomHelper.ChooseOne(POSSIBLE_NAMES);
            string lastName = RandomHelper.ChooseOne(POSSIBLE_NAMES);
            return firstName + " " + lastName;
        }
        public override void PrepareForLap(Race race)
        {
            if (race.IsThereABrokenTruck)
            {
                ActualSpeed = YELLOW_FLAG_SPEED;
            }
            else
            {
                ActualSpeed = NormalSpeed;
            }
        }
    }
}
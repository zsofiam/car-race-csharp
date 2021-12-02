

namespace CarRace.src
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Race race = new Race();
            CreateVehicles(race);

            race.SimulateRace();
            race.PrintRaceResults();
        }

        
        private static void CreateVehicles(Race race)
        {
            for (int i = 0; i < 10; i++)
            {
                race.RegisterRacer(new Car());
                race.RegisterRacer(new Motorcycle());
                race.RegisterRacer(new Truck());
            }
        }
    }
}

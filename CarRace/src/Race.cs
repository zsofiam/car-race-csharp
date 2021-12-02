using System;
using System.Collections.Generic;


namespace CarRace.src
{
    public class Race
    {
        private readonly List<Vehicle> _vehicles = new List<Vehicle>();
        private Weather _weather = new Weather();
        private static readonly int NUM_OF_LAPS = 50;
        public bool IsThereABrokenTruck { get; private set; }

        public void RegisterRacer(Vehicle racer)
        {
            _vehicles.Add(racer);
        }
        public void SimulateRace()
        {
            for (int i = 0; i < NUM_OF_LAPS; i++)
            {
                foreach (Vehicle vehicle in _vehicles)
                {
                    vehicle.PrepareForLap(this);
                    vehicle.MoveForAnHour();
                }

                _weather.Randomize();
                IsThereABrokenTruck = GetBrokenTruckStatus();
            }
        }

        private bool GetBrokenTruckStatus()
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle is Truck)
                {
                    Truck truck = (Truck)vehicle;
                    if (truck.IsBrokenDown)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        //private bool GetBrokenTruckStatusLINQ()
        //{
        //    return _vehicles
        //        .FindAll(v => v.GetType() == typeof(Truck))
        //        .Select(v => (Truck)v)
        //        .Any(t => t.IsBrokenDown);
        //}

        public void PrintRaceResults()
        {
            _vehicles.ForEach(e => Console.WriteLine(e));
        }
        public bool IsRaining => _weather.IsRaining;
    }
}

﻿using CarRace.src.Util;


namespace CarRace.src
{
    public class Weather
    {
        private const int CHANCE_OF_RAIN = 30;
        public bool IsRaining { get; private set; }

        public Weather()
        {
            Randomize();
        }

        public void Randomize()
        {
            IsRaining = RandomHelper.EventWithChance(CHANCE_OF_RAIN);
        }
    }
}

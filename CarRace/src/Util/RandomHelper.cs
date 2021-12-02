using System;


namespace CarRace.src.Util
{
    public class RandomHelper
    {
        private static readonly Random _random = new Random();
        private RandomHelper()
        {
        }
        public static int NextInt(int upper)
        {
            return _random.Next(upper);
        }

        public static string ChooseOne(string[] possibilities)
        {
            if (possibilities == null || possibilities.Length < 1)
            {
                const string msg =
                    "Possibilities should be a non-empty array of strings.";
                throw new ArgumentException(msg);
            }

            return possibilities[_random.Next(possibilities.Length)];
        }

        public static bool EventWithChance(int chance)
        {
            return _random.Next(100) < chance;
        }

        public static int NextInt(int lower, int upper)
        {
            return _random.Next(lower, upper);
        }
    }
}

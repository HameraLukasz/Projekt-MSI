using System;

namespace GA.Helpers
{
    public static class RandomProvider
    {
        public static Random Current { get; } = new Random();

        public static bool NextBool(this Random random, double probability = 0.5)
        {
            return random.NextDouble() < probability ? true : false;
        }
    }
}
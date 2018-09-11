using System;

namespace SAI.GA
{
    public static class Randomizer
    {
        private static Random Random { get; set; } = new Random(
            (int)DateTime.Now.Ticks);

        public static double Double()
        {
            return Random.NextDouble();
        }

        public static double Double(double minValue, double maxValue)
        {
            minValue = Math.Ceiling(minValue);
            maxValue = Math.Floor(maxValue);
            return Double() * (maxValue - minValue + 1.0d) + minValue;
        }

    }
}
using System;

namespace DartsGame
{
    public static class Darts
    {
        /// <summary>
        /// Calculates the earned points in a single toss of a Darts game.
        /// </summary>
        /// <param name="x">x-coordinate of dart.</param>
        /// <param name="y">y-coordinate of dart.</param>
        /// <returns>The earned points.</returns>
        public static int GetScore(double x, double y)
        {
            double length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (length <= 5)
            {
                return length <= 1 ? 10 : 5;
            }
            else
            {
                return length <= 10 ? 1 : 0;
            }
        }
    }
}

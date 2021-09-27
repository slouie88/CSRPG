using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    class RandomNumberGenerator
    {
        private static readonly Random _generator = new Random();

        public static int SimpleNumberBetween(int minValue, int maxValue)
        {
            return _generator.Next(minValue, maxValue + 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatWebApp
{
    public static class Utility
    {
        private static Random _random = new Random();

        public static int Clamp(int value, int min = 0, int max = 100) => Math.Clamp(value, min, max);

        public static int RandomStartValue() => _random.Next(60, 80);

        public static int RandomNumberBetween(int min, int max) => _random.Next(min, max + 1);
    }
}

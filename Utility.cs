using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatWebApp
{
    public static class Utility
    {
        public static int Clamp(int value, int min = 0, int max = 100)
        {
            return Math.Clamp(value, min, max);
        }

        public static int RandomStartValue()
        {
            Random rand = new Random();
            return rand.Next(80, 100);
        }

        public static int RandomValue(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
    }
}

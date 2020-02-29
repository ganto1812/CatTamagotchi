using System;

namespace CatWebApp
{
    public class Cat
    {

        public Cat(string name)
        {
            Name = name;
            Hunger = RandomStartValue();
            Health = RandomStartValue();
            PlayTime = RandomStartValue();
            Clean = RandomStartValue();
            Sleep = RandomStartValue();
        }

        public static int Clamp(int value, int min = 0, int max = 100)
        {
            return Math.Clamp(value, min, max);
        }

        public string Name { get; set; }

        private int _hunger;
        public int Hunger
        {
            get => _hunger;
            set => _hunger = Clamp(value);
        }

        private int _health;
        public int Health
        {
            get => _health;
            set => _health = Clamp(value);
        }

        private int _playTime;
        public int PlayTime
        {
            get => _playTime;
            set => _playTime = Clamp(value);
        }

        private int _clean;
        public int Clean
        {
            get => _clean;
            set => _clean = Clamp(value);
        }

        private int _sleep;
        public int Sleep
        {
            get => _sleep;
            set => _sleep = Clamp(value);
        }


        private int RandomStartValue()
        {
            // TODO: have rand be static too, and live in the class
            Random rand = new Random();
            return (rand.Next(80, 100));
        }
    }
}
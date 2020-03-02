using System;

namespace CatWebApp
{
    public class Cat
    {

        public Cat(string name)
        {
            Name = name;
            Hunger = Utility.RandomStartValue();
            Health = Utility.RandomStartValue();
            PlayTime = Utility.RandomStartValue();
            Clean = Utility.RandomStartValue();
            Sleep = Utility.RandomStartValue();
        }

        public string Name { get; set; }

        private int _hunger;
        public int Hunger
        {
            get => _hunger;
            set => _hunger = Utility.Clamp(value);
        }

        private int _health;
        public int Health
        {
            get => _health;
            set => _health = Utility.Clamp(value);
        }

        private int _playTime;
        public int PlayTime
        {
            get => _playTime;
            set => _playTime = Utility.Clamp(value);
        }

        private int _clean;
        public int Clean
        {
            get => _clean;
            set => _clean = Utility.Clamp(value);
        }

        private int _sleep;
        public int Sleep
        {
            get => _sleep;
            set => _sleep = Utility.Clamp(value);
        }
    }
}
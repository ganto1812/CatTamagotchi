using System;
using System.Text.Json.Serialization;

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
            LastAction = Action.None;
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

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Action LastAction { get; set; }

        //STATS FOR ACTIONS
        public void ApplyAction(HungerAction action)
        {
            if (LastAction != Action.Hunger)
            {
                LastAction = Action.Hunger;

                switch (action)
                {
                    case HungerAction.Milk:
                        Hunger += 7;
                        Clean -= Utility.RandomNumberBetween(3, 6);
                        Sleep -= Utility.RandomNumberBetween(2, 5);
                        break;
                    case HungerAction.Fish:
                        Hunger += 14;
                        Clean -= Utility.RandomNumberBetween(7, 10);
                        Sleep -= Utility.RandomNumberBetween(9, 15);
                        break;
                    case HungerAction.Sardines:
                        Hunger += 10;
                        Clean -= Utility.RandomNumberBetween(4, 10);
                        Sleep -= Utility.RandomNumberBetween(5, 15);
                        break;
                    default:
                        break;
                }
            }
        }

        public void ApplyAction(HealthAction action)
        {
            if (LastAction != Action.Health)
            {
                LastAction = Action.Health;
                switch (action)
                {
                    case HealthAction.Doctor:
                        Health += 13;
                        Hunger -= Utility.RandomNumberBetween(10, 18);
                        PlayTime -= Utility.RandomNumberBetween(6, 9);
                        Sleep -= Utility.RandomNumberBetween(14, 18);
                        break;
                    case HealthAction.Massage:
                        Health += 7;
                        Hunger -= Utility.RandomNumberBetween(7, 11);
                        PlayTime -= Utility.RandomNumberBetween(2, 8);
                        Sleep -= Utility.RandomNumberBetween(15, 20);
                        break;
                    case HealthAction.Pray:
                        Health += 1;
                        Hunger -= Utility.RandomNumberBetween(1, 10);
                        PlayTime -= Utility.RandomNumberBetween(1, 10);
                        Sleep -= Utility.RandomNumberBetween(1, 10);
                        break;
                    default:
                        break;
                }
            }
        }

        public void ApplyAction(PlayTimeAction action)
        {
            if (LastAction != Action.PlayTime)
            {
                LastAction = Action.PlayTime;
                switch (action)
                {
                    case PlayTimeAction.Fetch:
                        PlayTime += 5;
                        Clean -= Utility.RandomNumberBetween(2, 6);
                        Hunger -= Utility.RandomNumberBetween(1, 4);
                        break;
                    case PlayTimeAction.Laser:
                        PlayTime += 14;
                        Clean -= Utility.RandomNumberBetween(8, 12);
                        Hunger -= Utility.RandomNumberBetween(7, 15);
                        break;
                    case PlayTimeAction.Chase:
                        PlayTime += 6;
                        Clean -= Utility.RandomNumberBetween(3, 5);
                        Hunger -= Utility.RandomNumberBetween(2, 4);
                        break;
                    case PlayTimeAction.Wand:
                        PlayTime += 10;
                        Clean -= Utility.RandomNumberBetween(5, 10);
                        Hunger -= Utility.RandomNumberBetween(8, 10);
                        break;
                    default:
                        break;
                }
            }
        }

        public void ApplyAction(CleanAction action)
        {
            if (LastAction != Action.Clean)
            {
                LastAction = Action.Clean;
                switch (action)
                {
                    case CleanAction.Shower:
                        Clean += 8;
                        Hunger -= Utility.RandomNumberBetween(6, 9);
                        PlayTime -= Utility.RandomNumberBetween(1, 6);
                        break;
                    case CleanAction.Brush:
                        Clean += 17;
                        Hunger -= Utility.RandomNumberBetween(2, 15);
                        PlayTime -= Utility.RandomNumberBetween(1, 8);
                        break;
                    default:
                        break;
                }
            }
        }

        public void ApplyAction(SleepAction action)
        {
            if (LastAction != Action.Sleep)
            {
                LastAction = Action.Sleep;

                switch (action)
                {
                    case SleepAction.Nap:
                        Sleep += 6;
                        PlayTime -= Utility.RandomNumberBetween(6, 17);
                        Hunger -= Utility.RandomNumberBetween(5, 20); ;
                        break;
                    case SleepAction.Full:
                        Sleep += 14;
                        PlayTime -= Utility.RandomNumberBetween(10, 25);
                        Hunger -= Utility.RandomNumberBetween(8, 28);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
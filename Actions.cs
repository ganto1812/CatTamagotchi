using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatWebApp
{
    public enum HungerAction { None, Milk = 4, Fish = 13, Sardines = 9 }
    public enum HealthAction { None, Doctor = 14, Massage = 6, Pray = 1 }
    public enum PlayTimeAction { None, Fetch = 6, Laser = 10, Chase = 8, Wand = 14 }
    public enum CleanAction { None, Shower = 15, Brush = 7 }
    public enum SleepAction { None, Nap = 6, Full = 13 }

    public enum Action { None, Hunger, Health, PlayTime, Clean, Sleep }

}

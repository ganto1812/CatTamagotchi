using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CatWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {
        private readonly Cat _cat;

        public CatController(Cat cat)
        {
            _cat = cat;
        }

        [HttpGet]
        public Cat GetCat()
        {
            return _cat;
        }

        ActionLock actionLocked = new ActionLock();

        [HttpPost]
        [Route("hunger")]
        public void ChangeHunger(HungerAction action)
        {
            var available = true;
            if (!available)
            {
                return;
            }
            else
            {
                _cat.Hunger += (int)action;
                available = false;
            }
        }

        [HttpPost]
        [Route("health")]
        public void ChangeHealth(HealthAction action)
        {
            _cat.Health += (int)action;
        }

        [HttpPost]
        [Route("playtime")]
        public void ChangePlayTime(PlayTimeAction action)
        {
            _cat.PlayTime += (int)action;
        }

        [HttpPost]
        [Route("clean")]
        public void ChangeClean(CleanAction action)
        {
            _cat.Clean += (int)action;
        }

        [HttpPost]
        [Route("sleep")]
        public void ChangeSleep(SleepAction action)
        {
            _cat.Sleep += (int)action;
        }
    }
}
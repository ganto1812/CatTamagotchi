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

        [HttpPost]
        [Route("hunger")]
        public Cat ChangeHunger(HungerAction action)
        {
            _cat.ApplyAction(action);
            return _cat;
        }

        [HttpPost]
        [Route("health")]
        public Cat ChangeHealth(HealthAction action)
        {
            _cat.ApplyAction(action);
            return _cat;
        }

        [HttpPost]
        [Route("playtime")]
        public Cat ChangePlayTime(PlayTimeAction action)
        {
            _cat.ApplyAction(action);
            return _cat;
        }

        [HttpPost]
        [Route("clean")]
        public Cat ChangeClean(CleanAction action)
        {
            _cat.ApplyAction(action);
            return _cat;
        }

        [HttpPost]
        [Route("sleep")]
        public Cat ChangeSleep(SleepAction action)
        {
            _cat.ApplyAction(action);
            return _cat;
        }
    }
}
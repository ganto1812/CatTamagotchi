using Microsoft.AspNetCore.Mvc;

namespace CatWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {

    }

    // TODO: these have to belong to a method, and must as such be inside a controller :)
    [HttpGet]
    [Route("{states}")]
}
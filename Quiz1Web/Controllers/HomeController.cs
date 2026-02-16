using Microsoft.AspNetCore.Mvc;

namespace Quiz1Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "API funcionando correctamente";
        }
    }
}

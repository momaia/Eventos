using Microsoft.AspNetCore.Mvc;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public EventController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }
    }
}

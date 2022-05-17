using Microsoft.AspNetCore.Mvc;

namespace Appl.Controllers
{
    [ApiController]
    [Route("/")]
    public class HealthCheckController : Controller
    {
        [HttpGet("/healthycheck")]
        public ActionResult HealthyCheck()
        {
            return Ok("Healthy");
        }
    }
}

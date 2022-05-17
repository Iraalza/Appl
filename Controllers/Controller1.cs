using Appl.Models;
using Microsoft.AspNetCore.Mvc;

namespace Appl.Controllers
{
    [ApiController]
    [Route("/")]
    public class Controller1 : ControllerBase
    {
        [HttpGet("/model1")]
        public ActionResult<Model1> Get()
        {
            ICollection<string> models = new List<string>();
            string model1 = "Ira";
            string model2 = "Anna";
            models.Add(model1);
            models.Add(model2);
            Model1 modelsEntity = new Model1(models, 20);
            return Ok(modelsEntity);

        }
    }
}

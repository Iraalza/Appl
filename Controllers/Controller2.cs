using Appl.Models;
using Microsoft.AspNetCore.Mvc;

namespace Appl.Controllers
{
    public class Controller2 : ControllerBase
    {
        [ApiController]
        [Route("/")]
        public class Controller1 : ControllerBase
        {
            [HttpGet("/model2")]
            public ActionResult<Model2> Get()
            {
                ICollection<string> models = new List<string>();
                string model1 = "Ira";
                string model2 = "Anna";
                models.Add(model1);
                models.Add(model2);
                Model2 modelsEntity = new Model2(models, "Ivanova");
                return Ok(modelsEntity);

            }
        }
    }
}

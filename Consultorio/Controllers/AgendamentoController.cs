using Consultorio.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/Controller")]
    public class AgendamentoController : ControllerBase
    {
        

        public AgendamentoController()
        {
            

        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok();
        }


    }
}

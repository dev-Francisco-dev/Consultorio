using Consultorio.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/Controller")]
    public class AgendamentoController : ControllerBase
    {
        List<Agendamento> agendamentos = new List<Agendamento>();

        public AgendamentoController()
        {
            agendamentos.Add(new Agendamento
            {
                Id = 1,
                NomePaciente = "Francisco Alexandre",
                Horario = new DateTime(2021, 06, 20)

            });

        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(agendamentos);
        }


    }
}

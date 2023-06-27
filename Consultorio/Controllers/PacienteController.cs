using Consultorio.Models.Entities;
using Consultorio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/Controller")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _repository;
        

        public PacienteController(IPacienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var paciente = _repository.Get();

            return paciente.Any() 
                ? Ok(paciente)
                : BadRequest("Paciente Não encontrado!");
        }


    }
}

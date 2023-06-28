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
        public async Task<IActionResult> Get()
        {
            var paciente = await _repository.GetAsync();

            return paciente.Any()
                ? Ok(paciente)
                : BadRequest("Paciente Não encontrado!");
        }
        [HttpGet("{id}")]
        public async  Task<IActionResult> GetById(int id)
        {
            var paciente = await _repository.GetByIdAsync( id);

            return paciente != null
                ? Ok(paciente)
                : BadRequest("Paciente Não encontrado!");
        }


    }
}

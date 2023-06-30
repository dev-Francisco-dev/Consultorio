using AutoMapper;
using Consultorio.Models.Dtos;
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
        private readonly IMapper _mapper;

        public PacienteController(IPacienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pacientes = await _repository.GetAsync();

            var pacienteRetorno = _mapper.Map<IEnumerable<PacienteDetailsDto>>(pacientes);

            return pacienteRetorno != null
                ? Ok(pacienteRetorno)
                : BadRequest("Paciente Não encontrado!");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var paciente = await _repository.GetByIdAsync(id);

            var pacienteRetorno = new PacienteDetailsDto
            {
                Id = paciente.Id,
                Nome = paciente.Nome,
                Email = paciente.Email,
                Celular = paciente.Celular,
                Cpf = paciente.Cpf,
            };

            return pacienteRetorno != null
           ? Ok(pacienteRetorno)
           : BadRequest("Paciente Não encontrado!");
        }


    }


}


using AutoMapper;
using Consultorio.Models.Dtos;
using Consultorio.Models.Entities;
using Consultorio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/Controller/Paciente")]
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
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var pacientes = await _repository.GetByIdAsync(id);
            var pacienteRetorno = _mapper.Map<PacienteDetailsDto>(pacientes);

            return pacienteRetorno != null
           ? Ok(pacienteRetorno)
           : BadRequest("Paciente Não encontrado!");
        }

        [HttpPost]
        public async Task<IActionResult> Post(PacienteAdicionarDto paciente)
        {
            if (paciente == null) return BadRequest("Dados Invalidos");
            var pacienteRetornoAdicionar = _mapper.Map<Paciente>(paciente);
            _repository.Add(pacienteRetornoAdicionar);

            return await _repository.SavechangesAsync()
                ? Ok("Paciente adicionado com sucesso!")
                : BadRequest("Erro ao adicionar paciente");
        }

        [HttpPut("id")]
        public async Task<IActionResult> Put(int id,PacienteAtualizarDto paciente )
        {
            if (id <= 0) return BadRequest("Usuario não informado!");
            var pacientebanco = await _repository.GetByIdAsync(id);
            var pacienteAtualizar = _mapper.Map(paciente, pacientebanco);
            _repository.Update(pacienteAtualizar);
            return await _repository.SavechangesAsync()
                ? Ok("Paciente atualizado com sucesso") 
                : BadRequest("Erro ao atualizar Paciente");
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest("Paciente invalido");
            var pacienteExcluir = await _repository.GetByIdAsync(id);
            if (pacienteExcluir == null) return NotFound("Paciente não encontrado");
            _repository.Delete(pacienteExcluir);

            return await _repository.SavechangesAsync()
                ? Ok("Paciente deletado com sucesso")
                : BadRequest("Erro ao deletar Paciente");
        }
             
    }
}


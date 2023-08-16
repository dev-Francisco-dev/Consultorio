using AutoMapper;
using Consultorio.Models.Dtos;
using Consultorio.Models.Entities;
using Consultorio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/Controller/Profissional")]
    public class ProfissionalController : ControllerBase
    {
        private readonly IProfissionalRepository _repository;
        private readonly IMapper _mapper;

        public ProfissionalController(IProfissionalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var profissionals = await _repository.GetAsync();
            var profissionalRetorno = _mapper.Map<IEnumerable< ProfissionalAllDto>>(profissionals);

            return profissionalRetorno != null
                ? Ok(profissionalRetorno)
                : BadRequest("Profissional Não encontrado!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var profissional = await _repository.GetByIdAsync(id);
            var profissionalRetorno = _mapper.Map<ProfissionalDtoDetails>(profissional);
            return profissionalRetorno != null
                ? Ok(profissionalRetorno)
                : BadRequest("Profissional não encontrado");
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProfissionalAdicionarDto profissionalAdicionarDto)
        {
            if (profissionalAdicionarDto == null) return BadRequest("Dados Invalidos");
            var profissionalAdicionar = _mapper.Map<Profissional>(profissionalAdicionarDto);
            _repository.Add(profissionalAdicionar);

            return await _repository.SavechangesAsync()
                ? Ok("Profissional adicionado com sucesso!")
                : BadRequest("Erro ao adicionar profissional");

        }

        [HttpPut("id")]
        public async Task<IActionResult> Put(int id, ProfissionalAtualizarDto profissional)
        {
            if (id <= 0) return BadRequest("Profissional não informado!");
            var profissionalbanco = await _repository.GetByIdAsync(id);
            var profissionalAtualizar = _mapper.Map(profissional, profissionalbanco);
            _repository.Update(profissionalAtualizar);
            return await _repository.SavechangesAsync()
                ? Ok("profissional atualizado com sucesso")
                : BadRequest("Erro ao atualizar Profissional");
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest("Profssional invalido");
            var profissionalExcluir = await _repository.GetByIdAsync(id);
            if (profissionalExcluir == null) return NotFound("Profissional não encontrado");
            _repository.Delete(profissionalExcluir);

            return await _repository.SavechangesAsync()
                ? Ok("Profissional deletado com sucesso")
                : BadRequest("Erro ao deletar Profissional");
        }


    }
}


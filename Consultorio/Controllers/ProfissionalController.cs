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
      
        
    }
}


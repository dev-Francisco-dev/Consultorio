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
        
        public ProfissionalController(IProfissionalRepository repository)
        {
            _repository = repository;            
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var profissionals = await _repository.GetAsync();           

            return profissionals != null
                ? Ok(profissionals)
                : BadRequest("Profissional Não encontrado!");
        }
      
        
    }
}


using Consultorio.Models.Entities;

namespace Consultorio.Models.Dtos
{
    public class ProfissionalAdicionarDto
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public List<EspecialidadeDto> Especialidades { get; set; }

    }
}

using Consultorio.Models.Entities;

namespace Consultorio.Models.Dtos
{
    public class ProfissionalAllDto
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int NumeroConsultas { get; set; }
        public string[] TipoEspecialidades { get; set; }
    }
}

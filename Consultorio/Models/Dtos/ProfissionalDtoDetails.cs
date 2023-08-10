using Consultorio.Models.Entities;

namespace Consultorio.Models.Dtos
{
    public class ProfissionalDtoDetails
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int NumeroConsultas { get; set; }
        public string[] Especialidades { get; set; }
    }
}

namespace Consultorio.Models.Entities
{
    public class Agendamento: Base
    {
       
        public string? NomePaciente { get; set; }
        public DateTime Horario { get; set; }
    }
}

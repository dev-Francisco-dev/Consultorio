using Consultorio.Models.Entities;

namespace Consultorio.Repository.Interfaces
{
    public interface IPacienteRepository : IBaseRepository
    {
        IEnumerable<Paciente> Get();
        Paciente GetById(int id);
    }
}

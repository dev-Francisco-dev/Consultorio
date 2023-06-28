using Consultorio.Models.Entities;

namespace Consultorio.Repository.Interfaces
{
    public interface IPacienteRepository : IBaseRepository
    {
        Task<IEnumerable<Paciente>> GetAsync();
        Task<Paciente> GetByIdAsync(int id);
    }
}

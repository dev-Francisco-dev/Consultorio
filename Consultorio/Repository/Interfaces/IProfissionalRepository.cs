using Consultorio.Models.Entities;

namespace Consultorio.Repository.Interfaces
{
    public interface IProfissionalRepository : IBaseRepository
    {
        Task<IEnumerable<Profissional>> GetAsync();
        Task<Profissional> GetByIdAsync(int id);
    }
}

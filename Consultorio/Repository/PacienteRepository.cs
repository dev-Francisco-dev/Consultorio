using Consultorio.Context;
using Consultorio.Models.Entities;
using Consultorio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Repository
{
    public class PacienteRepository : BaseRepository, IPacienteRepository
    {
        private readonly ConsultorioContext _db;
        public PacienteRepository(ConsultorioContext db) : base(db) 
        {
            _db = db;
        }
        public async Task<IEnumerable<Paciente>> GetAsync()
        { 
            var paciente = await _db.Pacientes
                            .Include(x => x.Consultas)
                            .ToListAsync();
            return  paciente;
        }

        public async Task<Paciente> GetByIdAsync(int id)
        {
            var paciente = await _db.Pacientes
                .Include(x => x.Consultas)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return paciente; 
        }
    }
}

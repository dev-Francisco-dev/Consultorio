using Consultorio.Context;
using Consultorio.Models.Dtos;
using Consultorio.Models.Entities;
using Consultorio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Consultorio.Repository
{
    public class ProfissionalRepository : BaseRepository, IProfissionalRepository
    {
        private readonly ConsultorioContext _db;
        public ProfissionalRepository(ConsultorioContext db) : base(db)
        {
            _db = db;
        }
       
        public async Task<IEnumerable<Profissional>> GetAsync()
        {
            return await _db.Profissionais.ToListAsync();
        }

        public async Task<Profissional> GetByIdAsync(int id)
        {
            var profissional = await _db.Profissionais.FirstOrDefaultAsync(x => x.Id == id);
            return profissional!;
        }
    }
}

using Consultorio.Context;
using Consultorio.Models.Entities;
using Consultorio.Repository.Interfaces;

namespace Consultorio.Repository
{
    public class PacienteRepository : BaseRepository, IPacienteRepository
    {
        private readonly ConsultorioContext _db;
        public PacienteRepository(ConsultorioContext db) : base(db) 
        {
            _db = db;
        }
        public IEnumerable<Paciente> Get()
        { 
            var paciente = _db.Pacientes.ToList().OrderBy(x => x.Id);
            return paciente;
        }

        public Paciente GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

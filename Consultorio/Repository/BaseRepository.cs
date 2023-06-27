using Consultorio.Context;
using Consultorio.Repository.Interfaces;

namespace Consultorio.Repository
{    
    public class BaseRepository : IBaseRepository
    {
        private readonly ConsultorioContext _db;
        public BaseRepository(ConsultorioContext db)
        {
            _db = db;
        }
        public void Add<T>(T Entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T Entity) where T : class
        {
            throw new NotImplementedException();
        }

        public bool Savechanges()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T Entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}

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
            _db.Add(Entity);
        }

        public void Delete<T>(T Entity) where T : class
        {
            _db.Remove(Entity);
        }

        public async Task<bool> SavechangesAsync()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public void Update<T>(T Entity) where T : class
        {
            _db.Update(Entity);
        }
    }
}

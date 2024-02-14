using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfFileStoreRepository : EfBaseRepository<FileStore>, IFileStoreRepository
    {
        public IQueryable<FileStore> FileStores => Context.FileStores;

        public EfFileStoreRepository(EfDbContext db) : base(db)
        {
        }
    }
}
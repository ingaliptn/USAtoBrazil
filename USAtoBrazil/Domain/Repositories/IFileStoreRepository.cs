using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface IFileStoreRepository : IBaseRepository<FileStore>
    {
        IQueryable<FileStore> FileStores { get; }
    }
}
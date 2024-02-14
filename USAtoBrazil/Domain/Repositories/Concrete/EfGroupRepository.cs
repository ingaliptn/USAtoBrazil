using Domain.Entities;

namespace Domain.Repositories.Concrete
{
    public class EfGroupRepository(EfDbContext db) : EfBaseRepository<Group>(db), IGroupRepository
    {
        public IQueryable<Group> Groups => Context.Groups;
    }
}
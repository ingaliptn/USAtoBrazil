using Domain.Entities;

namespace Domain.Repositories
{
    public interface IGroupRepository : IBaseRepository<Group>
    {
        IQueryable<Group> Groups { get; }
    }
}
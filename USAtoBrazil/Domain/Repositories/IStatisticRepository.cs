using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface IStatisticRepository : IBaseRepository<Statistic>
    {
        IQueryable<Statistic> Statistics { get; }
    }
}
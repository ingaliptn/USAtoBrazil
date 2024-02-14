using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfStatisticRepository : EfBaseRepository<Statistic>, IStatisticRepository
    {
        public IQueryable<Statistic> Statistics => Context.Statistics;

        public EfStatisticRepository(EfDbContext db) : base(db)
        {
        }
    }
}
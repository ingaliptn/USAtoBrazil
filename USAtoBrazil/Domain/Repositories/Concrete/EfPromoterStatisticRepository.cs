using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfPromoterStatisticRepository : EfBaseRepository<PromoterStatistic>, IPromoterStatisticRepository
    {
        public IQueryable<PromoterStatistic> PromoterStatistics => Context.PromoterStatistics;

        public EfPromoterStatisticRepository(EfDbContext db) : base(db)
        {
        }
    }
}
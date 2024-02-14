using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface IPromoterStatisticRepository : IBaseRepository<PromoterStatistic>
    {
        IQueryable<PromoterStatistic> PromoterStatistics { get; }
    }
}
using Domain.Entities;
using System.Linq;

namespace Domain.Repositories {
    public interface IPromoterRepository : IBaseRepository<Promoter> {
        IQueryable<Promoter> Promoters { get; }
    }
}
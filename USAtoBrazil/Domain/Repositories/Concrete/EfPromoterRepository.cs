using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete {
    public class EfPromoterRepository : EfBaseRepository<Promoter>, IPromoterRepository {
        public IQueryable<Promoter> Promoters => Context.Promoters;

        public EfPromoterRepository(EfDbContext db) : base(db) {
        }
    }
}
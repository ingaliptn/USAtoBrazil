using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfTwilioCallRepository : EfBaseRepository<TwilioCall>, ITwilioCallRepository
    {
        public IQueryable<TwilioCall> TwilioCalls => Context.TwilioCalls;

        public EfTwilioCallRepository(EfDbContext db) : base(db)
        {
        }
    }
}
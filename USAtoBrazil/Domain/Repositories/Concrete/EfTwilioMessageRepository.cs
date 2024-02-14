using Domain.Entities;
using System.Linq;

namespace Domain.Repositories.Concrete
{
    public class EfTwilioMessageRepository : EfBaseRepository<TwilioMessage>, ITwilioMessageRepository
    {
        public IQueryable<TwilioMessage> TwilioMessages => Context.TwilioMessages;

        public EfTwilioMessageRepository(EfDbContext db) : base(db)
        {
        }
    }
}
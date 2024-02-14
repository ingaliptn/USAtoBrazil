using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface ITwilioMessageRepository : IBaseRepository<TwilioMessage>
    {
        IQueryable<TwilioMessage> TwilioMessages { get; }
    }
}
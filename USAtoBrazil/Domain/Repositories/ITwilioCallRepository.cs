using Domain.Entities;
using System.Linq;

namespace Domain.Repositories
{
    public interface ITwilioCallRepository : IBaseRepository<TwilioCall>
    {
        IQueryable<TwilioCall> TwilioCalls { get; }
    }
}
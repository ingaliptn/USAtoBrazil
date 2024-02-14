using System.Collections.Generic;
using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ITwilioPhoneRepository : IBaseRepository<TwilioPhone>
    {
        IQueryable<TwilioPhone> TwilioPhones { get; }

        Task TwilioPhoneCreateOrUpdate(TwilioPhone p,
            bool isMms, bool isSms, bool isVoice);

        Task<List<TwilioPhone>> TwilioPhoneGetListAs(string accountSid);
    }
}
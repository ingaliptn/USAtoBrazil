using System.Collections.Generic;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories.Concrete
{
    public class EfTwilioPhoneRepository : EfBaseRepository<TwilioPhone>, ITwilioPhoneRepository
    {
        public IQueryable<TwilioPhone> TwilioPhones => Context.TwilioPhones;

        public EfTwilioPhoneRepository(EfDbContext db) : base(db)
        {
        }

        public async Task TwilioPhoneCreateOrUpdate(TwilioPhone p,
            bool isMms, bool isSms, bool isVoice)
        {
            var q = TwilioPhones
                .AsNoTracking()
                .Where(z => z.Sid == p.Sid);
            var f = await q.AnyAsync();
            if (f)
            {
                var tp = await q.SingleAsync();
                p.Id = tp.Id;
                p.IsActive = tp.IsActive;
                p.IsMms = tp.IsMms && isMms;
                p.IsSms = tp.IsSms && isSms;
                p.IsVoice = tp.IsVoice && isVoice;
                Context.Update(p);
            }
            else
            {
                p.IsActive = true;
                p.IsMms = isMms;
                p.IsSms = isSms;
                p.IsVoice = isVoice;
                Context.Add(p);
            }
            await Context.SaveChangesAsync();
        }

        public async Task<List<TwilioPhone>> TwilioPhoneGetListAs(string accountSid)
        {
            var q = TwilioPhones.AsNoTracking()
                .Where(z => z.IsActive && z.AccountSid == accountSid);
            var f = await q.AnyAsync();
            if(!f) return new List<TwilioPhone>();
            return await q.OrderBy(z=>z.FriendlyName).ToListAsync();
        }
    }
}
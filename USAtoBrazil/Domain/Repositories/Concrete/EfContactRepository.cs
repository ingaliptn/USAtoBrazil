using System.Collections.Generic;
using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories.Concrete
{
    public class EfContactRepository : EfBaseRepository<Contact>, IContactRepository
    {
        public IQueryable<Contact> Contacts => Context.Contacts;

        public EfContactRepository(EfDbContext db) : base(db)
        {
        }

        public async Task ContactAddOrRemoveGroup(int contactId, int groupId)
        {
            var q = Contacts.Where(z => z.Id == contactId)
                .Include(z => z.ContactGroups)
                .ThenInclude(z => z.Group);
            var f = await q.AnyAsync();
            if (!f) return;
            var ag = await q.SingleAsync();
            if (ag.ContactGroups.Any(p => p.Group.Id == groupId))
            {
                var rl = await Context.Groups.Where(z => z.Id == groupId).SingleAsync();
                var r = ag.ContactGroups.Single(z => z.ContactId == ag.Id && z.GroupId == rl.Id);
                ag.ContactGroups.Remove(r);
                f = false;
            }

            if (f)
            {
                var rl = await Context.Groups.Where(z => z.Id == groupId).SingleAsync();
                ag.ContactGroups.Add(new ContactGroup
                {
                    Group = rl,
                    GroupId = rl.Id,
                    Contact = ag,
                    ContactId = ag.Id
                });
            }
            await Context.SaveChangesAsync();
        }

        public async Task<List<Contact>> ContactGetListAs(string accountSid)
        {
            var q = Contacts.AsNoTracking()
                .Where(z => z.AccountSid == accountSid);
            var f = await q.AnyAsync();
            if(!f) return new List<Contact>();
            return await q.ToListAsync();
        }
    }
}

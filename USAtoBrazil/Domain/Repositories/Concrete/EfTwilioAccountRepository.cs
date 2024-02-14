using System;
using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories.Concrete
{
    public class EfTwilioAccountRepository : EfBaseRepository<TwilioAccount>, ITwilioAccountRepository
    {
        public IQueryable<TwilioAccount?> TwilioAccounts => Context.TwilioAccounts;

        public EfTwilioAccountRepository(EfDbContext db) : base(db)
        {
        }

        public async Task<bool> TwilioAccountAdd(TwilioAccount u)
        {
            Context.Add(u);
            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<TwilioAccount> GetTwilioAccountFromUserIdAs(int userId)
        {
            return await TwilioAccounts
                .AsNoTracking().Where(z => z.User.Id == userId).SingleOrDefaultAsync();
        }

        public async Task<TwilioAccount> GetTwilioAccountFromUserId(int userId)
        {
            return await TwilioAccounts
                .Where(z => z.User.Id == userId).SingleOrDefaultAsync();
        }

        public async Task<TwilioAccount?> GetTwilioAccountAdminFromUserId(string userId)
        {
            var id = Convert.ToInt32(userId);
            var user = await Context.Users
                .Where(z => z.Id == id).SingleAsync();
            if (user.Role == "admin")
            {
                return await TwilioAccounts
                    .Where(z => z!.User.Id == user.Id).SingleOrDefaultAsync();
            }

            var adminId = await Context.Users
                .Where(z => z.Username == user.AdminUserName).Select(z => z.Id).SingleAsync();
            return await TwilioAccounts
                .Where(z => z!.User.Id == adminId).SingleOrDefaultAsync();
        }

        public async Task<string> GetTwilioAccountSidAdminFromUserId(string userId)
        {
            var id = Convert.ToInt32(userId);
            var adminUserName = await Context.Users
                .Where(z => z.Id == id).Select(z => z.AdminUserName).SingleAsync();
            var adminId = await Context.Users
                .Where(z => z.Username == adminUserName).Select(z => z.Id).SingleAsync();
            return await TwilioAccounts
                .Where(z => z.User.Id == adminId).Select(z=>z.Sid).SingleOrDefaultAsync();
        }
    }
}
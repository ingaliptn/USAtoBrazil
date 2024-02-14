using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories.Concrete
{
    public class EfUserRepository : EfBaseRepository<User>, IUserRepository
    {
        public IQueryable<User> Users => Context.Users;

        public EfUserRepository(EfDbContext db) : base(db)
        {
        }

        public async Task<bool> UserAdd(User u)
        {
            var q = Users.Where(z => z.Username == u.Username);
            var f = await q.AnyAsync();
            if (f) return false;
            Context.Add(u);
            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<User> GetFromIdentity(string username, string password)
        {
            return await Users.Where(z=>!z.IsDeleted && z.IsActive && z.Username == username &&
            z.Password == password)
            .FirstOrDefaultAsync();
        }

        public async Task UserSetActive(int id)
        {
            var q = Users.Where(z => z.Id == id);
            var f = await q.AnyAsync();
            if (!f) return;
            var ag = await q.SingleAsync();
            ag.IsActive = !ag.IsActive;
            await Context.SaveChangesAsync();
        }

        public async Task<User> UserFromIdS(int id)
        {
            var q = Users.AsNoTracking()
                .Where(z => z.Id == id);
            var f = await q.AnyAsync();
            if (!f) return new User();
            return await q.SingleAsync();
        }

        public async Task<string> UserGetAdminName(string userId)
        {
            var id = Convert.ToInt32(userId);
            return await Users.Where(z => z.Id == id)
                .Select(z => z.AdminUserName).SingleAsync();
        }
    }
}

using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories.Concrete
{
    public class EfUserLoginRepository : EfBaseRepository<UserLogin>, IUserLoginRepository
    {
        public IQueryable<UserLogin> UserLogins => Context.UserLogins;

        public EfUserLoginRepository(EfDbContext db) : base(db)
        {
        }

        public async Task<bool> UserLoginAdd(UserLogin u)
        {
            Context.Add(u);
            await Context.SaveChangesAsync();
            return true;
        }
    }
}

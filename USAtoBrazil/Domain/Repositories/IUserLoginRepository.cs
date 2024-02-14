using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUserLoginRepository : IBaseRepository<UserLogin>
    {
        IQueryable<UserLogin> UserLogins { get; }
        Task<bool> UserLoginAdd(UserLogin u);
    }
}

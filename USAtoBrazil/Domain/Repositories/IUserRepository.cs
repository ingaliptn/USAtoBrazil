using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        IQueryable<User> Users { get; }
        Task<User> GetFromIdentity(string username, string password);
        Task UserSetActive(int id);
        Task<User> UserFromIdS(int id);
        Task<bool> UserAdd(User u);
        Task<string> UserGetAdminName(string userId);
    }
}

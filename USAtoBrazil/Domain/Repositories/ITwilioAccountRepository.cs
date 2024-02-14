using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ITwilioAccountRepository : IBaseRepository<TwilioAccount>
    {
        IQueryable<TwilioAccount?> TwilioAccounts { get; }
        Task<bool> TwilioAccountAdd(TwilioAccount u);
        Task<TwilioAccount> GetTwilioAccountFromUserIdAs(int userId);
        Task<TwilioAccount> GetTwilioAccountFromUserId(int userId);
        Task<TwilioAccount?> GetTwilioAccountAdminFromUserId(string userId);
        Task<string> GetTwilioAccountSidAdminFromUserId(string userId);
    }
}
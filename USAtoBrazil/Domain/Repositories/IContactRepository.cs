using System.Collections.Generic;
using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IContactRepository : IBaseRepository<Contact>
    {
        IQueryable<Contact> Contacts { get; }
        Task ContactAddOrRemoveGroup(int contactId, int groupId);
        Task<List<Contact>> ContactGetListAs(string accountSid);
    }
}
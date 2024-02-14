using System.Collections.Generic;

namespace Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ContactGroup> ContactGroups { get; set; } = new List<ContactGroup>();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ContactGroup
    {
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}

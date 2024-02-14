using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime CreatedBy { get; set; }
        [MaxLength(20)]
        public string? Status { get; set; }
        public string ContactType { get; set; }
        public string Name { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? Email { get; set; }
        [MaxLength(200)]
        public string Phones { get; set; }
        public string? Address { get; set; }
        public string? RaceHair { get; set; }
        public string? Commentary { get; set; }
        [MaxLength(40)]
        public string AccountSid { get; set; }
        public string? Src { get; set; }
        [MaxLength(20)]
        public string? PhoneStatus { get; set; }
        public string? Note { get; set; }
        public int UserId { get; set; }
        public DateTime NoteCreate { get; set; } 
        public ICollection<ContactGroup> ContactGroups { get; set; } = new List<ContactGroup>();
        public ICollection<FileStore> FileStores { get; set; } = new List<FileStore>();
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class TwilioMessage
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string AccountSid { get; set; }
        [MaxLength(40)]
        public string Sid { get; set; }
        public DateTime DateCreated { get; set; }
        public string Body { get; set; }
        [MaxLength(20)]
        public string From { get; set; }
        [MaxLength(20)]
        public string To { get; set; }
        public string Status { get; set; }
        public bool IsRead { get; set; }
        public bool IsTwilio { get; set; }
        public string? AgentName { get; set; }
        //public virtual User User { get; set; }
    }
}

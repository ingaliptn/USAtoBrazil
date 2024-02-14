using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class TwilioCall
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string AccountSid { get; set; }
        [MaxLength(40)]
        public string Sid { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime EndTime { get; set; }
        [MaxLength(20)]
        public string From { get; set; }
        [MaxLength(40)]
        public string To { get; set; }
        public string Status { get; set; }
    }
}


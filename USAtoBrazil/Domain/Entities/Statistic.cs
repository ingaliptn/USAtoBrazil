using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Statistic
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        [MaxLength(40)]
        public string AccountSid { get; set; }
        public int Count { get; set; }
        public bool IsSms { get; set; }
    }
}

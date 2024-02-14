using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PromoterStatistic
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string Ip { get; set; }

        public int PromoterId { get; set; }

        [ForeignKey("PromoterId")]
        public Promoter Promoter { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Domain.Entities {
    public class Promoter {
        public int Id { get; set; }
        public DateTime OpenTime { get; set; } = DateTime.Now;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Code { get; set; }
        public string QrCodePath { get; set; }
        public ICollection<PromoterStatistic> PromoterStatistics { get; set; } = new List<PromoterStatistic>();
    }
}

using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class TwilioAccount
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        [MaxLength(40)]
        public string Sid { get; set; }
        [MaxLength(40)]
        public string Token { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class UserLogin
    {
        public int Id { get; set; }
        public DateTime LoginTime { get; set; } = DateTime.Now;
        public DateTime LogOutTime { get; set; } = DateTime.Now;
        [MaxLength(20)]
        public required string Ip { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;
    }
}

using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class TwilioPhone
    {
        public int Id { get; set; }
        public string FriendlyName { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(40)]
        public string AccountSid { get; set; }
        [MaxLength(40)]
        public string Sid { get; set; }
        public string Uri { get; set; }
        public bool IsMms { get; set; }
        public bool IsSms { get; set; }
        public bool IsVoice { get; set; }
        public bool IsActive { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class FileStore
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public required string FileName { get; set; }
        [MaxLength(50)]
        public required string Folder { get; set; }
        [MaxLength(50)]
        public required string FileNameGuid { get; set; }
    }
}

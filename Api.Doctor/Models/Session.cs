using System.ComponentModel.DataAnnotations;

namespace Api.Doctor.Models
{
    public class Session
    {
        [Key]
        [StringLength(36)]
        public string Sid { get; set; } = null!;
        public DateTime? Expires { get; set; }
        public string? Data { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

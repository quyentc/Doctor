using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Doctor.Models
{
    public class SupporterLog
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? SupporterId { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation
        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }
        [ForeignKey("SupporterId")]
        public User? Supporter { get; set; }
    }
}

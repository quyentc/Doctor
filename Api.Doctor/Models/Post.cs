using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Doctor.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ContentMarkdown { get; set; }
        public string? ContentHTML { get; set; }
        public int? ForDoctorId { get; set; }
        public int? ForSpecializationId { get; set; }
        public int? ForClinicId { get; set; }
        public int WriterId { get; set; }
        public bool? ConfirmByDoctor { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        [ForeignKey("ForClinicId")]
        public Clinic? Clinic { get; set; }
        [ForeignKey("ForSpecializationId")]
        public Specialization? Specialization { get; set; }
        [ForeignKey("ForDoctorId")]
        public User? ForDoctor { get; set; }
        [ForeignKey("WriterId")]
        public User Writer { get; set; } = null!;
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Doctor.Models
{
    public class DoctorUser
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int ClinicId { get; set; }
        public int SpecializationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        [ForeignKey("DoctorId")]
        public User Doctor { get; set; } = null!;

        [ForeignKey("ClinicId")]
        public Clinic Clinic { get; set; } = null!;

        [ForeignKey("SpecializationId")]
        public Specialization Specialization { get; set; } = null!;
    }
}

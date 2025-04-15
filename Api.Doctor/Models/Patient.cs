using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Doctor.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int StatusId { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? DateBooking { get; set; }
        public string? TimeBooking { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? Year { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public bool IsSentForms { get; set; } = false;
        public bool IsTakeCare { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation
        [ForeignKey("DoctorId")]
        public User Doctor { get; set; } = null!;
        [ForeignKey("StatusId")]
        public Status Status { get; set; } = null!;
        public ExtraInfo? ExtraInfo { get; set; }
        public ICollection<SupporterLog>? SupporterLogs { get; set; }
    }
}

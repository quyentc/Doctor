using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Doctor.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public string? MaxBooking { get; set; }
        public string? SumBooking { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation
        [ForeignKey("DoctorId")]
        public User Doctor { get; set; } = null!;
    }
}

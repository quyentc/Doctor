using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Doctor.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public string? TimeBooking { get; set; }
        public string? DateBooking { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Content { get; set; }
        public bool Status { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation
        [ForeignKey("DoctorId")]
        public User? Doctor { get; set; }
    }
}

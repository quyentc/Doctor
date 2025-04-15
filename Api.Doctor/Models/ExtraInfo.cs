using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Doctor.Models
{
    public class ExtraInfo
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public string? HistoryBreath { get; set; }
        public int? PlaceId { get; set; }
        public string? OldForms { get; set; }
        public string? SendForms { get; set; }
        public string? MoreInfo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation
        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }
    }
}

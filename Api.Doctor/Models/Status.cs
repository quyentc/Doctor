namespace Api.Doctor.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation
        public ICollection<Patient>? Patients { get; set; }
    }
}

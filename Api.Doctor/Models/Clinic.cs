namespace Api.Doctor.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? IntroductionHTML { get; set; }
        public string? IntroductionMarkdown { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        public ICollection<DoctorUser>? DoctorUsers { get; set; }
        public ICollection<Post>? Posts { get; set; }
    }
}

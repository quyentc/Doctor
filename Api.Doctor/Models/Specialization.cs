namespace Api.Doctor.Models
{
    public class Specialization
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation
        public ICollection<DoctorUser>? DoctorUsers { get; set; }
        public ICollection<Post>? Posts { get; set; }
    }
}

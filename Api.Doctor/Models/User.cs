using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
namespace Api.Doctor.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Avatar { get; set; }

        // Mặc định là "male". Bạn có thể cấu hình mặc định này thông qua Fluent API nếu cần.
        public string Gender { get; set; } = "male";

        public string? Description { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        [ForeignKey("RoleId")]
        public Role Role { get; set; } = null!;

        // Nếu đây là bác sĩ, các quan hệ dưới đây có thể được dùng:
        public ICollection<DoctorUser>? DoctorUsers { get; set; }
        public ICollection<Patient>? Patients { get; set; }
        public ICollection<Post>? WrittenPosts { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Schedule>? Schedules { get; set; }
        public ICollection<Post>? PostsForDoctor { get; set; }
        public ICollection<SupporterLog>? SupporterLogs { get; set; }
    }
}


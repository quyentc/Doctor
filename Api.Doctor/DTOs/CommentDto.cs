namespace Api.Doctor.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public string Content { get; set; } = string.Empty;
        public string? Name { get; set; }
    }
}

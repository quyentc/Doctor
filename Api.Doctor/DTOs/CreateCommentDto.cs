namespace Api.Doctor.DTOs
{
    public class CreateCommentDto
    {
        public int? DoctorId { get; set; }
        public string Content { get; set; } = string.Empty;
        public string? Name { get; set; }
    }
}

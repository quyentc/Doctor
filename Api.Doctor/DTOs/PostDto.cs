namespace Api.Doctor.DTOs
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ContentMarkdown { get; set; } = string.Empty;
        public int? ForClinicId { get; set; }
        public int? ForSpecializationId { get; set; }
        public int? ForDoctorId { get; set; }
    }
}

namespace Api.Doctor.DTOs
{
    public class SupporterLogDto
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? SupporterId { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}

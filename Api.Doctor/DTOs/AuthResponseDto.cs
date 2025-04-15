namespace Api.Doctor.DTOs
{
    public class AuthResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        // Token có thể được tạo từ JWT trong production
        public string Token { get; set; } = string.Empty;
    }
}

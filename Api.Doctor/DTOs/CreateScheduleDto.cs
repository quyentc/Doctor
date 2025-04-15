namespace Api.Doctor.DTOs
{
    public class CreateScheduleDto
    {
        public int DoctorId { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        // Các thuộc tính bổ sung nếu cần (như MaxBooking)
    }
}

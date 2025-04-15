
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;

namespace Api.Doctor.Repositories.Interfaces
{
    public interface IClinicRepository : IBaseRepository<Clinic>
    {
        // Có thể thêm các hàm chuyên biệt, ví dụ: tìm kiếm theo tên.
    }
}

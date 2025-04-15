using System.ComponentModel.DataAnnotations;

namespace Api.Doctor.Models
{
    public class SequelizeMeta
    {
        [Key]
        public string Name { get; set; } = null!;
    }
}

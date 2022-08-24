using System.ComponentModel.DataAnnotations;

namespace Dosaaf.Models
{
    public class OnlineEducation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Не указана фамилия")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Не указан телефон")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Не указан Email")]
        public string? Email { get; set; }
        public string? Category { get; set; }
        public DateTime? TimeCreated { get; set; }
    }
}

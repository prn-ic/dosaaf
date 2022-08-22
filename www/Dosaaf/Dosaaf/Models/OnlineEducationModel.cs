using System.ComponentModel.DataAnnotations;

namespace Dosaaf.Models
{
    public class OnlineEducationModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        public string? FirstName { get; set; } = "Нет данных";
        [Required(ErrorMessage = "Не указана фамилия")]
        public string? LastName { get; set; } = "Нет данных";
        [Required(ErrorMessage = "Не указан телефон")]
        public string? Phone { get; set; } = "Нет данных";
        [Required(ErrorMessage = "Не указан Email")]
        public string? Email { get; set; } = "Нет данных";
        public string? Category { get; set; } = "Нет данных";
        public DateTime? TimeCreated { get; set; }
    }
}

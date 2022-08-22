using System.ComponentModel.DataAnnotations;

namespace Dosaaf.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Не указано имя")]
        public string? Name { get; set; } = "Нет данных";
        [Required(ErrorMessage = "Не введен email")]
        public string? Email { get; set; } = "Нет данных";
        [Required(ErrorMessage = "Не введено сообщение")]
        public string? Message { get; set; } = "Нет данных";
        public DateTime TimeCreated { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Dosaaf.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Не указано имя")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Не введен email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Не введено сообщение")]
        public string? Message { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}

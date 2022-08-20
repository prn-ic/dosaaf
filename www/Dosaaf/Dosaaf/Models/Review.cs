namespace Dosaaf.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}

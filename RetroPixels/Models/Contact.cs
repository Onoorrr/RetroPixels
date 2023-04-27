using System.ComponentModel.DataAnnotations;

namespace RetroPixels.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string? ImageURL { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [MaxLength(10)]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}

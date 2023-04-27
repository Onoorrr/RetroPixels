using System.ComponentModel.DataAnnotations;

namespace RetroPixels.Models
{
    public class MainPage
    {
        [Key]
        public int Id { get; set; }       
        public string? ImageURL { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}

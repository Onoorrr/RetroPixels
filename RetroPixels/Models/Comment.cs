using System.ComponentModel.DataAnnotations;
namespace RetroPixels.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan gerekli")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Bu alan gerekli")]        
        public string Details { get; set; }
        [Required(ErrorMessage = "Bu alan gerekli")]
        public string Email { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}

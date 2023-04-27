namespace RetroPixels.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ImageURL { get; set; }
        public string DownloadLink { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public virtual GameDetail? GameDetail { get; set; }
    }
}

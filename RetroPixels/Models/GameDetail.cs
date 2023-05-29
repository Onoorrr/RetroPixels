namespace RetroPixels.Models
{
    public class GameDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }        
        public int GameId { get; set; }
        public virtual Game? Game { get; set; }
    }
}

namespace SongAPI.Domain.Models
{
    public class Song
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Artist { get; set; }
        public int Year { get; set; }
        public string Album { get; set; } = string.Empty;
    }
}

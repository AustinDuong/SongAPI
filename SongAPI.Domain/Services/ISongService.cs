using SongAPI.Domain.Models;

namespace SongAPI.Domain.Services
{
    public interface ISongService
    {
        Task<List<Song>> GetAllSongs();
        Task<Song> GetSong(int id);
        Task AddSong(Song song);
        Task Update (Song song);
        Task Delete (int id);
    }
}

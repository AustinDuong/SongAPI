using SongAPI.Domain.Models;

namespace SongAPI.Domain.Services
{
    public interface ISongService
    {
        Task<IEnumerable<Song>> GetAllSongs();
        Task<Song> GetSong(int id);
        Task Update (Song song);
        Task Delete (int id);
    }
}

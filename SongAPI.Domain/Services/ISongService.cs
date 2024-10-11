using SongAPI.Domain.Models;

namespace SongAPI.Domain.Services
{
    public interface ISongService
    {
        Task<List<Song>> GetAllSongs();
        Task<Song> GetSong(int id);
        Task AddSong(Song song);
        Task UpdateSong (Song updatedSong);
        Task DeleteSong (int id);
    }
}

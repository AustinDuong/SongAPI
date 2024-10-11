using SongAPI.Domain.Models;
using SongAPI.Domain.Services;
using SongAPI.Domain.Repositories;

namespace SongAPI.Services
{
    // This is where business logic would go. For a simple project like this, it's not needed, but it's nice
    // to have for separation of concerns. This is especially useful if you plan to scale the project in the future.
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository _songRepository)
        {
            this._songRepository = _songRepository;
        }


        public Task<List<Song>> GetAllSongs()
        {
            return _songRepository.GetAllSongs();
        }

        public Task<Song> GetSong(int id)
        {
            return _songRepository.GetSong(id);
        }

        public async Task AddSong(Song song)
        {
            await _songRepository.AddSong(song);
        }

        public Task UpdateSong(Song updatedSong)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSong(int id)
        {
            throw new NotImplementedException();
        }

    }
}

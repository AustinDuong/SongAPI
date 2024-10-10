using SongAPI.Domain.Models;
using SongAPI.Domain.Services;
using SongAPI.Domain.Repositories;

namespace SongAPI.Services
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository _songRepository)
        {
            this._songRepository = _songRepository;
        }


        public Task<IEnumerable<Song>> GetAllSongs()
        {
            return _songRepository.GetAllSongs();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Song> GetSong(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Song song)
        {
            throw new NotImplementedException();
        }
    }
}

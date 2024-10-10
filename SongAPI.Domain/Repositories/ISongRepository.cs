using SongAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongAPI.Domain.Repositories
{
    public interface ISongRepository
    {
        Task<IEnumerable<Song>> GetAllSongs();
        Task<Song> GetSong(int id);
        void Update(Song song);
        void Delete(int id);
    }
}

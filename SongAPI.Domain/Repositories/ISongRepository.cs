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
        Task<List<Song>> GetAllSongs();
        Task<Song> GetSong(int id);
        Task AddSong(Song song);
        Task UpdateSong(Song updatedSong);
        Task DeleteSong(int id);
    }
}

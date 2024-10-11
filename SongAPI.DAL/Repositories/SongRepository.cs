using Microsoft.EntityFrameworkCore;
using SongAPI.DAL.Data;
using SongAPI.Domain.Models;
using SongAPI.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongAPI.DAL.Repositories
{
    // This is where all of your database access should happen.
    public class SongRepository : ISongRepository
    {
        private readonly DatabaseContext _databaseContext;

        public SongRepository(DatabaseContext databaseContext) 
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<Song>> GetAllSongs()
        {
            try
            {
                return await _databaseContext.Songs.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<Song> GetSong(int id)
        {
            try
            {
                Song songQuery = _databaseContext.Songs
                    .Single(s => s.Id == id);
                return songQuery;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task AddSong(Song song)
        {
            throw new NotImplementedException();
        }

        public void Update(Song song)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}

using Microsoft.EntityFrameworkCore;
using SongAPI.DAL.Data;
using SongAPI.Domain.Models;
using SongAPI.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public async Task AddSong(Song song)
        {
            await _databaseContext.AddAsync(song);
            try
            {
                await _databaseContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                var entries = ex.Entries;
                foreach (var entry in entries)
                {
                    Debug.WriteLine(entry);
                }
            }
        }

        public async Task UpdateSong(Song updatedSong)
        {
            var dbSong = await _databaseContext.Songs.FindAsync(updatedSong.Id);

            if(dbSong == null)
            {
                throw new KeyNotFoundException("Song not found.");
            }

            dbSong.Title = updatedSong.Title;
            dbSong.Artist = updatedSong.Artist;
            dbSong.Year = updatedSong.Year;
            dbSong.Album = updatedSong.Album;

            await _databaseContext.SaveChangesAsync();
        }

        public async Task DeleteSong(int id)
        {
            var dbSong = await _databaseContext.Songs.FindAsync(id);

            if (dbSong == null)
            {
                throw new KeyNotFoundException("Song not found.");
            }

            _databaseContext.Songs.Remove(dbSong);
            await _databaseContext.SaveChangesAsync();
        }

    }
}

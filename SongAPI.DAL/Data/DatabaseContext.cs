using Microsoft.EntityFrameworkCore;
using SongAPI.Domain.Models;

namespace SongAPI.DAL.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }
    }
}

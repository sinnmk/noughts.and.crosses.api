using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NoughtsAndCrosses.Src.Repositories.Interfaces;
using NoughtsAndCrosses.Src.Repositories.Models;

namespace NoughtsAndCrosses.Src.Repositories
{
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<Player> Players { get; set; }
        public Task SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=noughtsandcrosses-db.db");
        }
    }
}

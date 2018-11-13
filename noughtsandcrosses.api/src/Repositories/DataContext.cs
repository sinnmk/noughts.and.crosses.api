using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NoughtsAndCrosses.Server.Src.Repositories.Interfaces;
using NoughtsAndCrosses.Server.Src.Repositories.Models;

namespace NoughtsAndCrosses.Server.Src.Repositories
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

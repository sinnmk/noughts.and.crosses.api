using Microsoft.EntityFrameworkCore;
using noughtsandcrosses.api.Models;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.Server.Repositories.Models;

namespace noughtsandcrosses.api.Repositories
{
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<SignUp> SignUps { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = NoughtsAndCrosses");
//            optionsBuilder.UseSqlite("Data Source = NoughtsAndCrosses.db");
        }
    }
}

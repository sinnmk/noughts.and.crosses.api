using Microsoft.EntityFrameworkCore;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories
{
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Game> Games { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=databasefile.db");
        }
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Board>(entity =>
//            {
//                entity.HasKey(p => p.BoardId);
//            });
//
//            base.OnModelCreating(modelBuilder);
//        }
    }
}

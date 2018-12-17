using Microsoft.EntityFrameworkCore;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories
{
    public class DataContext : DbContext, IDataContext
    {

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=noughtsandcrosses-db.db");
        }
    }
}

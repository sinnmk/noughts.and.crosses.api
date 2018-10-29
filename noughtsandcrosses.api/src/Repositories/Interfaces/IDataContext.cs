using Microsoft.EntityFrameworkCore;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories.Interfaces
{
    public interface IDataContext
    {
        DbSet<Game> Games { get; set; }
        DbSet<Board> Boards { get; set; }
        DbSet<Player> Players { get; set; }
        int SaveChanges();
    }
}

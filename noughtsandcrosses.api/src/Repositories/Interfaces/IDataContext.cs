using Microsoft.EntityFrameworkCore;
using noughtsandcrosses.api.Models;
using noughtsandcrosses.Server.Repositories.Models;

namespace noughtsandcrosses.api.Repositories.Interfaces
{
    public interface IDataContext
    {
        DbSet<Game> Games { get; set; }
        DbSet<Board> Boards { get; set; }
        DbSet<Player> Players { get; set; }
        DbSet<SignUp> SignUps { get; set; }
        int SaveChanges();
    }
}

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NoughtsAndCrosses.Server.Src.Repositories.Models;

namespace NoughtsAndCrosses.Server.Src.Repositories.Interfaces
{
    public interface IDataContext
    {
        DbSet<Game> Games { get; set; }
        DbSet<Board> Boards { get; set; }
        DbSet<Player> Players { get; set; }
        int SaveChanges();
        Task SaveChangesAsync();
    }
}

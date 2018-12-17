using Microsoft.EntityFrameworkCore;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories.Interfaces
{
    public interface IDataContext
    {
        DbSet<Game> Games { get; set; }
        int SaveChanges();
    }
}

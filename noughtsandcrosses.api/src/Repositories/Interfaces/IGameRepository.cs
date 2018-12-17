using System.Collections.Generic;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories.Interfaces
{
    public interface IGameRepository
    {
        List<Game> GetGames();
        Game AddGame(Game game);
        bool UpdateGame(Game game);
    }
}

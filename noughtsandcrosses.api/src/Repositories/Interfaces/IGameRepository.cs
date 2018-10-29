using System.Collections.Generic;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories.Interfaces
{
    public interface IGameRepository
    {
        Game AddGame(Game game);
        bool UpdateGame(Game game);
        bool DeleteGame(Game game);
        List<Game> GetGames();
    }
}

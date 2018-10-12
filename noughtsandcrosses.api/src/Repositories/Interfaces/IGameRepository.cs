using System.Collections.Generic;
using noughtsandcrosses.api.Models;

namespace noughtsandcrosses.api.Repositories.Interfaces
{
    public interface IGameRepository
    {
        Game CreateGame(Game game);
        bool UpdateGame(Game game);
        bool DeleteGame(Game game);
        List<Game> GetGames();
    }
}

using System.Collections.Generic;
using NoughtsAndCrosses.Server.Src.Repositories.Models;

namespace NoughtsAndCrosses.Server.Src.Repositories.Interfaces
{
    public interface IGameRepository
    {
        List<Game> GetGames();
        Game AddGame(Game game);
        bool UpdateGame(Game game);
        bool DeleteGame(int id);
    }
}

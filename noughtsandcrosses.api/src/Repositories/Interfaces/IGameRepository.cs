using System.Collections.Generic;
using NoughtsAndCrosses.Src.Repositories.Models;

namespace NoughtsAndCrosses.Src.Repositories.Interfaces
{
    public interface IGameRepository
    {
        List<Game> GetGames();
        Game AddGame(Game game);
        bool UpdateGame(Game game);
        bool DeleteGame(int id);
    }
}

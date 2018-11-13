using System.Collections.Generic;
using NoughtsAndCrosses.Src.Repositories.Models;

namespace NoughtsAndCrosses.Src.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Player AddPlayer(Player player);
        List<Player> GetPlayers();
        bool UpdatePlayer(Player player);
        bool DeletePlayer(int id);
    }
}

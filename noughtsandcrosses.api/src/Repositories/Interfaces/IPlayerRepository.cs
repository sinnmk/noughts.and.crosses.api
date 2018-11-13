using System.Collections.Generic;
using NoughtsAndCrosses.Server.Src.Repositories.Models;

namespace NoughtsAndCrosses.Server.Src.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Player AddPlayer(Player player);
        List<Player> GetPlayers();
        bool UpdatePlayer(Player player);
        bool DeletePlayer(int id);
    }
}

using System.Collections.Generic;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Player AddPlayer(Player player);
        List<Player> GetPlayers();
        bool UpdatePlayer(Player player);
    }
}

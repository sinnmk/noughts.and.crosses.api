using System.Collections.Generic;
using noughtsandcrosses.api.Models;

namespace noughtsandcrosses.api.src.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Player AddPlayer(Player player);
        List<Player> GetPlayers();
    }
}

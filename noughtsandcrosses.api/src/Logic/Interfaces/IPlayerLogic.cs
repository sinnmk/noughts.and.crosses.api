using System.Collections.Generic;
using noughtsandcrosses.api.Dtos;

namespace noughtsandcrosses.api.Logic.Interfaces
{
    public interface IPlayerLogic
    {
        PlayerDto CreatePlayer(PlayerDto playerDto);
        List<PlayerDto> GetPlayers();
        bool UpdatePlayer(PlayerDto playerDto);
    }
}

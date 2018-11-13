using System.Collections.Generic;
using NoughtsAndCrosses.Server.Src.Logic.Dtos;

namespace NoughtsAndCrosses.Server.Src.Logic.Interfaces
{
    public interface IPlayerLogic
    {
        PlayerDto CreatePlayer(PlayerDto playerDto);
        List<PlayerDto> GetPlayers();
        bool UpdatePlayer(PlayerDto playerDto);
        bool DeletePlayer(int id);
    }
}

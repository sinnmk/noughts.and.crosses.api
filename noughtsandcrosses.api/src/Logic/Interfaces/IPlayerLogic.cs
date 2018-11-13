using System.Collections.Generic;
using NoughtsAndCrosses.Src.Logic.Dtos;

namespace NoughtsAndCrosses.Src.Logic.Interfaces
{
    public interface IPlayerLogic
    {
        PlayerDto CreatePlayer(PlayerDto playerDto);
        List<PlayerDto> GetPlayers();
        bool UpdatePlayer(PlayerDto playerDto);
        bool DeletePlayer(int id);
    }
}

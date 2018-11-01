using System.Collections.Generic;
using NoughtsAndCrosses.Server.Src.Logic.Dtos;

namespace NoughtsAndCrosses.Server.Src.Logic.Interfaces
{
    public interface IGameLogic
    {
        List<GameDto> GetGames();
        GameDto CreateGame(GameDto gameDto);
        bool UpdateGame(GameDto gameDto);
        bool DeleteGame(int boardId);
    }
}

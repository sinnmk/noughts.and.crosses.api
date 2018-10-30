using System.Collections.Generic;
using noughtsandcrosses.api.Logic.Dtos;

namespace noughtsandcrosses.api.Logic.Interfaces
{
    public interface IGameLogic
    {
        List<GameDto> GetGames();
        GameDto CreateGame(GameDto gameDto);
        bool UpdateGame(GameDto gameDto);
        bool DeleteGame(int boardId);
    }
}

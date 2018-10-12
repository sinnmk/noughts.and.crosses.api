using System.Collections.Generic;
using noughtsandcrosses.api.Dtos;
using noughtsandcrosses.api.Models;

namespace noughtsandcrosses.api.Logic.Interfaces
{
    public interface IGameLogic
    {
        GameDto CreateGame(GameDto gameDto);
        bool UpdateGame(GameDto gameDto);
        bool DeleteGame(GameDto gameDto);
        List<GameDto> GetGames();
    }
}

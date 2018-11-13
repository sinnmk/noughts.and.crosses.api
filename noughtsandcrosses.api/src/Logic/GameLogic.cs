using System.Collections.Generic;
using NoughtsAndCrosses.Src.Logic.Dtos;
using NoughtsAndCrosses.Src.Logic.Interfaces;
using NoughtsAndCrosses.Src.Repositories.Interfaces;

namespace NoughtsAndCrosses.Src.Logic
{
    public class GameLogic : IGameLogic
    {
        private readonly IGameRepository _gameRepository;

        public GameLogic(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public List<GameDto> GetGames()
        {
            var games = Mapper.MapGames(_gameRepository.GetGames());
            return games;
        }

        public GameDto CreateGame(GameDto gameDto)
        {
            var game = _gameRepository.AddGame(Mapper.MapGameDtoToGame(gameDto));
            return Mapper.MapGameToGameDto(game);
        }

        public bool UpdateGame(GameDto gameDto)
        {
            _gameRepository.UpdateGame(Mapper.MapGameDtoToGame(gameDto));
            return true;
        }

        public bool DeleteGame(int boardId)
        {
            _gameRepository.DeleteGame(boardId);
            return true;
        }
    }
}


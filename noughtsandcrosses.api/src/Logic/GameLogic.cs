using System.Collections.Generic;
using noughtsandcrosses.api.Dtos;
using noughtsandcrosses.api.Logic.Interfaces;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.api.src.Dtos;

namespace noughtsandcrosses.api.src.Logic
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
            var game = _gameRepository.CreateGame(Mapper.MapGameDtoToGame(gameDto));
            return Mapper.MapGameToGameDto(game);
        }

        public bool UpdateGame(GameDto gameDto)
        {
            _gameRepository.UpdateGame(Mapper.MapGameDtoToGame(gameDto));
            return true;
        }

        public bool DeleteGame(GameDto gameDto)
        {
            _gameRepository.DeleteGame(Mapper.MapGameDtoToGame(gameDto));
            return true;
        }
    }
}


using System.Collections.Generic;
using System.Linq;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Logic.Dtos
{
    public class Mapper
    {
        public static Game MapGameDtoToGame(GameDto gameDto)
        {
            var newGame = new Game()
            {
                GameId = gameDto.GameId,
                TurnChoice = gameDto.TurnChoice,
                GameLevel = gameDto.GameLevel,
                BoardDimension = gameDto.BoardDimension,
                IsGameOver = gameDto.IsGameOver,
                IsGameWon = gameDto.IsGameWon
            };
            return newGame;
        }

        public static GameDto MapGameToGameDto(Game game)
        {
            var newGameDto = new GameDto()
            {
                GameId = game.GameId,
                TurnChoice = game.TurnChoice,
                GameLevel = game.GameLevel,
                BoardDimension = game.BoardDimension,
                IsGameOver = game.IsGameOver,
                IsGameWon = game.IsGameWon
            };
            return newGameDto;
        }

        public static List<GameDto> MapGames(IList<Game> games)
        {
            return games.Select(game => new GameDto
            {
                GameId = game.GameId,
                TurnChoice = game.TurnChoice,
                GameLevel = game.GameLevel,
                BoardDimension = game.BoardDimension,
                IsGameOver = game.IsGameOver,
                IsGameWon = game.IsGameWon
            }).ToList();
        }
    }
}

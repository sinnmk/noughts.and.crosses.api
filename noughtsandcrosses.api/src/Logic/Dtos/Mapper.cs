using System.Collections.Generic;
using System.Linq;
using noughtsandcrosses.api.Dtos;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Logic.Dtos
{
    public class Mapper
    {
        public static List<BoardDto> MapBoards(IList<Board> boards)
        {
            return boards.Select(b => new BoardDto
            {
                BoardId = b.BoardId,
                BoardDimension = b.BoardDimension,
                IsTerminal = b.IsTerminal
            }).ToList();
        }

        public static Board MapBoardDtoToBoard(BoardDto boardDto)
        {
            var newBoard = new Board()
            {
                BoardId = boardDto.BoardId,
                BoardDimension = boardDto.BoardDimension,
                IsTerminal = boardDto.IsTerminal
            };

            return newBoard;
        }

        public static BoardDto MapBoardToBoardDto(Board board)
        {
            var newBoardDto = new BoardDto()
            {
                BoardId = board.BoardId,
                BoardDimension = board.BoardDimension,
                IsTerminal = board.IsTerminal
            };

            return newBoardDto;
        }

        public static Player MapPlayerDtoToPlayer(PlayerDto playerDto)
        {
            var newPlayer = new Player()
            {
                PlayerId = playerDto.PlayerId,
                PlayerLevel = playerDto.PlayerLevel,
                PlayerName = playerDto.PlayerName,
            };

            return newPlayer;
        }

        public static PlayerDto MapPlayerToPlayerDto(Player player)
        {
            var newPlayerDto = new PlayerDto()
            {
                PlayerId = player.PlayerId,
                PlayerLevel = player.PlayerLevel,
                PlayerName = player.PlayerName
            };

            return newPlayerDto;
        }

        public static Game MapGameDtoToGame(GameDto gameDto)
        {
            var newGame = new Game()
            {
                GameId = gameDto.GameId,
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
                IsGameWon = game.IsGameWon,
                IsGameOver = game.IsGameOver
            }).ToList();

        }

        public static List<PlayerDto> MapPlayers(IList<Player> players)
        {
            return players.Select(player => new PlayerDto()
            {
                PlayerId = player.PlayerId,
                PlayerName = player.PlayerName,
                PlayerLevel = player.PlayerLevel
            }).ToList();
        }
    }
}

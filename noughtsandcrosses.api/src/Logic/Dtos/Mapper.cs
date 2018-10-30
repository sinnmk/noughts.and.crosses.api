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
                BoardState = b.BoardState,
                IsTerminal = b.IsTerminal
            }).ToList();
        }

        public static Board MapBoardIdDtoToBoard(int id)
        {
            return new Board
            {
                BoardId = id
            };
        }

        public static Board MapBoardDtoToBoard(BoardDto boardDto)
        {
            return new Board
            {
                BoardId = boardDto.BoardId,
                BoardDimension = boardDto.BoardDimension,
                BoardState = boardDto.BoardState,
                IsTerminal = boardDto.IsTerminal

            };

        }

        public static BoardDto MapBoardToBoardDto(Board board)
        {
            return new BoardDto
            {
                BoardId = board.BoardId,
                BoardDimension = board.BoardDimension,
                BoardState = board.BoardState,
                IsTerminal = board.IsTerminal
            };
        }

        public static Player MapPlayerDtoToPlayer(PlayerDto playerDto)
        {
            return new Player
            {
                PlayerId = playerDto.PlayerId,
                PlayerLevel = playerDto.PlayerLevel,
                PlayerName = playerDto.PlayerName,
            };
        }

        public static PlayerDto MapPlayerToPlayerDto(Player player)
        {
            return new PlayerDto
            {
                PlayerId = player.PlayerId,
                PlayerLevel = player.PlayerLevel,
                PlayerName = player.PlayerName
            };
        }

        public static Game MapGameDtoToGame(GameDto gameDto)
        {
            return new Game
            {
                GameId = gameDto.GameId,
                IsGameOver = gameDto.IsGameOver,
                IsGameWon = gameDto.IsGameWon
            };
        }

        public static GameDto MapGameToGameDto(Game game)
        {
            return new GameDto
            {
                GameId = game.GameId,
                IsGameOver = game.IsGameOver,
                IsGameWon = game.IsGameWon
            };
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

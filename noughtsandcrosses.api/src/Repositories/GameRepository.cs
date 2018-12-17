using System;
using System.Collections.Generic;
using System.Linq;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories
{
    public class GameRepository: IGameRepository
    {
        private readonly IDataContext _dataContext;

        public GameRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Game> GetGames()
        {
            var games = _dataContext.Games.ToList();
            return games;
        }

        public Game AddGame(Game game)
        {
            var newGame = new Game
            {
                GameId = game.GameId,
                TurnChoice = game.TurnChoice,
                GameLevel = game.GameLevel,
                BoardDimension = game.BoardDimension,
                IsGameOver = game.IsGameOver,
                IsGameWon = game.IsGameWon
            };
            _dataContext.Games.Add(game);
            _dataContext.SaveChanges();
            return newGame;
        }

        public bool UpdateGame(Game game)
        {
            var existingGame = _dataContext.Games.FirstOrDefault(x => x.GameId == game.GameId);
            if (existingGame != null)
            {
                existingGame.GameId = game.GameId;
                existingGame.BoardDimension = game.BoardDimension;
                existingGame.GameLevel = game.GameLevel;
                existingGame.TurnChoice = game.TurnChoice;
                existingGame.IsGameOver = game.IsGameOver;
                existingGame.IsGameWon = game.IsGameWon;
            }

            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteGame(int id)
        {
            var gameToDelete = _dataContext.Games.FirstOrDefault(x => x.GameId == id);
            if (gameToDelete == null) throw new Exception("Game not found");

            _dataContext.Games.Remove(gameToDelete);
            _dataContext.SaveChanges();
            return true;
        }
    }
}


using System.Collections.Generic;
using System.Linq;
using noughtsandcrosses.api.Models;
using noughtsandcrosses.api.Repositories.Interfaces;

namespace noughtsandcrosses.api.Repositories
{
    public class GameRepository: IGameRepository
    {
        private readonly IDataContext _dataContext;

        public GameRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Game CreateGame(Game game)
        {
            var newGame = _dataContext.Games.Add(game);
            _dataContext.SaveChanges();
            return game;
        }

        public bool UpdateGame(Game game)
        {
            var existingGame = _dataContext.Games.FirstOrDefault(x => x.GameId == game.GameId);
            if (existingGame != null)
            {
                existingGame.IsGameOver = game.IsGameOver;
                existingGame.IsGameWon = game.IsGameWon;
            }

            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteGame(Game game)
        {
            var existingGame = _dataContext.Games.FirstOrDefault(x => x.GameId == game.GameId);
            if (existingGame != null)
            {
                _dataContext.Games.Remove(game);
            }

            _dataContext.SaveChanges();
            return true;
        }

        public List<Game> GetGames()
        {
            var games = _dataContext.Games.ToList();
            return games;
        }
    }
}

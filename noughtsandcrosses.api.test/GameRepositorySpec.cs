using System.Linq;
using noughtsandcrosses.api.Repositories;
using noughtsandcrosses.api.Repositories.Models;
using Xunit;

namespace noughtsandcrosses.api.test
{
    public class GameRepositorySpec
    {
        [Fact]
        public void AddGame_CreatesASingleInstanceOfAGame()
        {
            var dataContext = new DataContext();

            var game = new Game{GameId = 1, GameLevel = 1, BoardDimension = 3, IsGameOver = false, IsGameWon = false, TurnChoice = 1};
            var gameRepository = new GameRepository(dataContext);
            gameRepository.AddGame(game);

            Assert.Equal(1, dataContext.Games.Count());
        }
    }
}

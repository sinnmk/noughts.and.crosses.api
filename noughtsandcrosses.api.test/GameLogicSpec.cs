using Moq;
using noughtsandcrosses.api.Logic;
using noughtsandcrosses.api.Logic.Dtos;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.api.Repositories.Models;
using Xunit;

namespace noughtsandcrosses.api.test
{
    public class GameLogicSpec
    {
        [Fact]
        public void CreateGame_CallsCreateGameInGameRepository()
        {
            var gameRepoMock = new Mock<IGameRepository>();
            gameRepoMock.Setup(x => x.AddGame(It.IsAny<Game>())).Returns(new Game());
            var logicLayer = new GameLogic(gameRepoMock.Object);
            logicLayer.CreateGame(new GameDto());
            gameRepoMock.Verify(x => x.AddGame(It.IsAny<Game>()));
        }

        [Fact]
        public void UpdateGame_CallsUpdateGameInGameRepository()
        {
            var gameRepoMock = new Mock<IGameRepository>();
            var logicLayer = new GameLogic(gameRepoMock.Object);
            gameRepoMock.Setup(x => x.UpdateGame(It.IsAny<Game>()));
            var gameDto = new GameDto()
            {
                GameId = 1,
                IsGameOver = true
            };
            logicLayer.UpdateGame(gameDto);
            gameRepoMock.Verify(x => x.UpdateGame(It.Is<Game>(p => p.GameId == 1 && p.IsGameOver == true)));
        }
    }
}

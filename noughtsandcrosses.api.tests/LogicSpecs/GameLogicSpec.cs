using Xunit;
using Moq;
using NoughtsAndCrosses.Src.Logic;
using NoughtsAndCrosses.Src.Logic.Dtos;
using NoughtsAndCrosses.Src.Repositories.Interfaces;
using NoughtsAndCrosses.Src.Repositories.Models;

namespace TestTicTacToe.LogicSpecs
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
            gameRepoMock.Verify(x =>x.AddGame(It.IsAny<Game>()));
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

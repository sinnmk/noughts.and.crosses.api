using Xunit;
using Moq;
using noughtsandcrosses.api.Modules;
using Nancy.Json;
using Nancy.Testing;
using NoughtsAndCrosses.Src.Logic.Dtos;
using NoughtsAndCrosses.Src.Logic.Interfaces;
using NoughtsAndCrosses.Src.Repositories.Models;

namespace TestTicTacToe.ModuleSpecs
{
    public class GameModuleSpec
    {
        private readonly Browser _browser;
        private readonly Mock<IGameLogic> _mockGameLogic;

        public GameModuleSpec()
        {
            _mockGameLogic = new Mock<IGameLogic>();
            _browser = new Browser(with =>
                {
                    with.Dependencies(_mockGameLogic.Object);
                    with.Module<GameModule>();
                },
                to => to.Accept("application/json"));
        }

        [Fact]
        public void CanCallPostGame()
        {
            var json = new JavaScriptSerializer().Serialize(new Game());
            _browser.Post("game/", with =>
            {
                with.HttpRequest();
                with.Body(json, "application/json");
            });
            _mockGameLogic.Verify(x => x.CreateGame(It.IsAny<GameDto>()));
        }
    }
}

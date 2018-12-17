using Moq;
using noughtsandcrosses.api.Logic.Dtos;
using noughtsandcrosses.api.Logic.Interfaces;
using noughtsandcrosses.api.Modules;
using noughtsandcrosses.api.Repositories.Models;
using Nancy.Json;
using Nancy.Testing;
using Xunit;

namespace noughtsandcrosses.api.test
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
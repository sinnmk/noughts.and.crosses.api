using Moq;
using noughtsandcrosses.api.Logic.Dtos;
using noughtsandcrosses.api.Logic.Interfaces;
using noughtsandcrosses.api.Modules;
using noughtsandcrosses.api.Repositories.Models;
using Nancy.Json;
using Nancy.Testing;
using Xunit;

namespace noughtsandcrosses.api.tests.Modules
{
    public class BoardModuleSpec
    {
        private readonly Browser _browser;
        private readonly Mock<IBoardLogic> _mockBoardLogic;

        public BoardModuleSpec()
        {
            _mockBoardLogic = new Mock<IBoardLogic>();
            _browser = new Browser(with =>
                {
                    with.Dependencies(_mockBoardLogic.Object);
                    with.Module<BoardModule>();
                },
                to => to.Accept("application/json"));
        }

        [Fact]
        public void CanCallGetOnBoardEndpoint()
        {
            var json = new JavaScriptSerializer().Serialize(new Board());
            _browser.Get("boards/", with =>
            {
                with.HttpRequest();
                with.Body(json, "application/json");
            });
            _mockBoardLogic.Verify(x => x.GetBoards());
        }

        [Fact]
        public void CanCallPostOnBoardEndpoint()
        {
            var json = new JavaScriptSerializer().Serialize(new Board());
            _browser.Post("boards/", with =>
            {
                with.HttpRequest();
                with.Body(json, "application/json");
            });
            _mockBoardLogic.Verify(x => x.CreateBoard(It.IsAny<BoardDto>()));
        }

        [Fact]
        public void CanCallPutOnBoardEndpoint()
        {
            var json = new JavaScriptSerializer().Serialize(new Board());
            _browser.Put("boards/", with =>
            {
                with.HttpRequest();
                with.Body(json, "application/json");
            });
            _mockBoardLogic.Verify(x => x.UpdateBoard(It.IsAny<BoardDto>()));
        }

        [Fact]
        public void CanCallDeleteOnBoardEndpoint()
        {
            var json = new JavaScriptSerializer().Serialize(new Board());
            _browser.Post("boards/", with =>
            {
                with.HttpRequest();
                with.Body(json, "application/json");
            });
            _mockBoardLogic.Verify(x => x.DeleteBoard(1));
        }
    }
}
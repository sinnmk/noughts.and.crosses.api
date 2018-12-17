using Moq;
using NoughtsAndCrosses.Src.Repositories.Interfaces;
using Xunit;

namespace noughtsandcrosses.tests.LogicSpecs
{
    public class PlayerLogicSpec
    {
        [Fact]
        public void CreatePlayer_CallsAddPlayerInPlayerRepository()
        {
            var playerRepoMock = new Mock<IPlayerRepository>();

        }

        [Fact]
        public void UpdatePlayer_CallsUpdatePlayerInPlayerRepository()
        {

        }

        [Fact]
        public void DeletePlayer_CallsDeletePlayerInPlayerRepository()
        {

        }

        [Fact]
        public void GetPlayers_CallsGetPlayersInPlayerRepository()
        {

        }
    }
}
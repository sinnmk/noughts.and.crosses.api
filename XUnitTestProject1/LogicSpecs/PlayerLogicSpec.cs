using Xunit;
using Moq;
using NoughtsAndCrosses.Server.Src.Repositories.Interfaces;

namespace TestTicTacToe.LogicSpecs
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

using Xunit;
using Moq;
using NoughtsAndCrosses.Server.Src.Logic;
using NoughtsAndCrosses.Server.Src.Logic.Dtos;
using NoughtsAndCrosses.Server.Src.Repositories.Interfaces;
using NoughtsAndCrosses.Server.Src.Repositories.Models;

namespace TestTicTacToe.LogicSpecs
{
    public class BoardLogicSpec
    {
        [Fact]
        public void CreateBoard_CallsAddBoardInBoardRepository()
        {
            var boardRepoMock = new Mock<IBoardRepository>();
            boardRepoMock.Setup(x => x.AddBoard(It.IsAny<Board>())).Returns(new Board());
            var logicLayer = new BoardLogic(boardRepoMock.Object);
            logicLayer.CreateBoard(new BoardDto());
            boardRepoMock.Verify(x => x.AddBoard(It.IsAny<Board>()));
        }

        [Fact]
        public void UpdateBoard_CallsUpdateBoardInBoardRepository()
        {
            var boardRepoMock = new Mock<IBoardRepository>();
            var logicLayer = new BoardLogic(boardRepoMock.Object);
            boardRepoMock.Setup(x => x.UpdateBoard(It.IsAny<Board>()));
            var boardDto = new BoardDto()
            {
                BoardId = 1, 
                BoardDimension = 4
            };
            logicLayer.UpdateBoard(boardDto);
            boardRepoMock.Verify(x => x.UpdateBoard(It.Is<Board>(p => p.BoardId == 1 && p.BoardDimension == 4)));
        }

        [Fact]
        public void GetBoards_CallsGetBoardsInBoardRepository()
        {
            var boardRepoMock = new Mock<IBoardRepository>();
            var logicLayer = new BoardLogic(boardRepoMock.Object);
        }
    }
}

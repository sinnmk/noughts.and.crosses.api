using System.Collections.Generic;
using NoughtsAndCrosses.Server.Src.Logic.Dtos;
using NoughtsAndCrosses.Server.Src.Repositories.Models;

namespace NoughtsAndCrosses.Server.Src.Logic.Interfaces
{
    public interface IBoardLogic
    {
        List<BoardDto> GetBoards();
        BoardDto CreateBoard(BoardDto boardDto);
        bool UpdateBoard(BoardDto boardDto);
        bool DeleteBoard(int boardId);
    }
}

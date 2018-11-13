using System.Collections.Generic;
using NoughtsAndCrosses.Src.Repositories.Models;
using NoughtsAndCrosses.Src.Logic.Dtos;

namespace NoughtsAndCrosses.Src.Logic.Interfaces
{
    public interface IBoardLogic
    {
        List<BoardDto> GetBoards();
        BoardDto CreateBoard(BoardDto boardDto);
        bool UpdateBoard(BoardDto boardDto);
        bool DeleteBoard(int boardId);
    }
}

using System.Collections.Generic;
using noughtsandcrosses.api.Dtos;
using noughtsandcrosses.api.Models;

namespace noughtsandcrosses.api.Logic.Interfaces
{
    public interface IBoardLogic
    {
        List<BoardDto> GetBoards();
        BoardDto CreateBoard(BoardDto boardDto);
        bool UpdateBoard(BoardDto boardDto);
        bool DeleteBoard(BoardDto boardDto);
    }
}

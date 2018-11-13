using System.Collections.Generic;
using NoughtsAndCrosses.Src.Repositories.Models;

namespace NoughtsAndCrosses.Src.Repositories.Interfaces
{
    public interface IBoardRepository
    {
        List<Board> GetBoards();
        Board AddBoard(Board board);
        bool UpdateBoard(Board board);
        bool DeleteBoard(int id);
    }
}

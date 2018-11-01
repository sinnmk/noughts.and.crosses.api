using System.Collections.Generic;
using NoughtsAndCrosses.Server.Src.Repositories.Models;

namespace NoughtsAndCrosses.Server.Src.Repositories.Interfaces
{
    public interface IBoardRepository
    {
        List<Board> GetBoards();
        Board AddBoard(Board board);
        bool UpdateBoard(Board board);
        bool DeleteBoard(int id);
    }
}

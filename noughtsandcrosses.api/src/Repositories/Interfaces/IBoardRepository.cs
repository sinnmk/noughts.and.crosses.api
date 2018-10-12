using System.Collections.Generic;
using noughtsandcrosses.api.Models;

namespace noughtsandcrosses.api.Repositories.Interfaces
{
    public interface IBoardRepository
    {
        Board CreateBoard(Board board);
        List<Board> GetBoards();
        bool UpdateBoard(Board board);
        bool DeleteBoard(Board board);
    }
}

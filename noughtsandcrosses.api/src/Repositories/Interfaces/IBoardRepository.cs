using System.Collections.Generic;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories.Interfaces
{
    public interface IBoardRepository
    {
        Board AddBoard(Board board);
        List<Board> GetBoards();
        bool UpdateBoard(Board board);
        bool DeleteBoard(Board board);
    }
}

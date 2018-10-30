using System.Collections.Generic;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories.Interfaces
{
    public interface IBoardRepository
    {
        List<Board> GetBoards();
        Board AddBoard(Board board);
        bool UpdateBoard(Board board);
        bool DeleteBoard(int id);
    }
}

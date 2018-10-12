using System.Collections.Generic;
using System.Linq;
using noughtsandcrosses.api.Models;
using noughtsandcrosses.api.Repositories.Interfaces;

namespace noughtsandcrosses.api.Repositories
{
    public class BoardRespository: IBoardRepository
    {
        private readonly IDataContext _dataContext;

        public BoardRespository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Board CreateBoard(Board board)
        {
            var newBoard = _dataContext.Boards.Add(board);
            _dataContext.SaveChanges();
            return new Board();
        }

        public List<Board> GetBoards()
        {
            var boards = _dataContext.Boards.ToList();
            return boards;
        }

        public bool UpdateBoard(Board board)
        {
            var existingBoard = _dataContext.Boards.FirstOrDefault(x => x.BoardId == board.BoardId);
            if (existingBoard != null)
            {
                existingBoard.IsTerminal = existingBoard.IsTerminal;
            }

            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteBoard(Board board)
        {
            var existingBoard = _dataContext.Boards.FirstOrDefault(x => x.BoardId == board.BoardId);
            if (existingBoard != null)
            {
                _dataContext.Boards.Remove(board);
            }

            _dataContext.SaveChanges();
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.api.Repositories.Models;

namespace noughtsandcrosses.api.Repositories
{
    public class BoardRespository: IBoardRepository
    {
        private readonly IDataContext _dataContext;

        public BoardRespository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Board AddBoard(Board board)
        {
            var newBoard = new Board { BoardDimension = 3, IsTerminal = board.IsTerminal};
            _dataContext.Boards.Add(newBoard);
            _dataContext.SaveChanges();
            return newBoard;
        }

        public List<Board> GetBoards()
        {
            var boards = _dataContext.Boards.ToList();
            return boards;
        }

        public bool UpdateBoard(Board board)
        {
            var existingBoard = _dataContext.Boards.FirstOrDefault(x => x.BoardId == board.BoardId);
            if (existingBoard == null)
            {
                throw new Exception("Board was not found");
            }

            existingBoard.BoardDimension = board.BoardDimension;
            existingBoard.IsTerminal = board.IsTerminal;

            _dataContext.Boards.Update(board);
            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteBoard(Board board)
        {
            var existingBoard = _dataContext.Boards.FirstOrDefault(x => x.BoardId == board.BoardId);
            if (existingBoard == null)
            {
                throw new Exception("Board was not found.");
            }

            _dataContext.Boards.Remove(board);
            _dataContext.SaveChanges();
            return true;
        }
    }
}

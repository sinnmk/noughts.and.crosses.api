using System;
using System.Collections.Generic;
using System.Linq;
using NoughtsAndCrosses.Src.Repositories.Interfaces;
using NoughtsAndCrosses.Src.Repositories.Models;

namespace NoughtsAndCrosses.Src.Repositories
{
    public class BoardRespository : IBoardRepository
    {
        private readonly IDataContext _dataContext;

        public BoardRespository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Board> GetBoards()
        {
            var boards = _dataContext.Boards.ToList();
            return boards;
        }

        public Board AddBoard(Board board)
        {
            var newBoard = new Board
            {
                BoardDimension = 3,
                IsTerminal = board.IsTerminal,
                BoardState = board.BoardState
            };
            _dataContext.Boards.Add(newBoard);
            _dataContext.SaveChanges();
            return newBoard;
        }

        public bool UpdateBoard(Board board)
        {
            var existingBoard = _dataContext.Boards.FirstOrDefault(x => x.BoardId == board.BoardId);
            if (existingBoard == null) throw new Exception("Board was not found");

            existingBoard.BoardDimension = board.BoardDimension;
            existingBoard.IsTerminal = board.IsTerminal;
            existingBoard.BoardState = board.BoardState;

            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteBoard(int id)
        {
            var boardToDelete = _dataContext.Boards.FirstOrDefault(x => x.BoardId == id);

            if (boardToDelete == null) throw new Exception("Board was not found.");

            _dataContext.Boards.Remove(boardToDelete);
            _dataContext.SaveChanges();
            return true;
        }
    }
}
using System.Collections.Generic;
using noughtsandcrosses.api.Dtos;
using noughtsandcrosses.api.Logic.Interfaces;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.api.src.Dtos;

namespace noughtsandcrosses.api.src.Logic
{
    public class BoardLogic : IBoardLogic
    {
        private readonly IBoardRepository _boardRepository;

        public BoardLogic(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public List<BoardDto> GetBoards()
        {
            var boards = Mapper.MapBoards(_boardRepository.GetBoards());
            return boards;
        }

        public BoardDto CreateBoard(BoardDto boardDto)
        {
            var board = _boardRepository.CreateBoard(Mapper.MapBoardDtoToBoard(boardDto));
            return Mapper.MapBoardToBoardDto(board);
        }

        public bool UpdateBoard(BoardDto boardDto)
        {
            _boardRepository.UpdateBoard(Mapper.MapBoardDtoToBoard(boardDto));
            return true;
        }

        public bool DeleteBoard(BoardDto boardDto)
        {
            _boardRepository.DeleteBoard(Mapper.MapBoardDtoToBoard(boardDto));
            return true;
        }
    }
}

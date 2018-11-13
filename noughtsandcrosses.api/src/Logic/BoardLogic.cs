﻿using System.Collections.Generic;
using NoughtsAndCrosses.Src.Logic.Dtos;
using NoughtsAndCrosses.Src.Logic.Interfaces;
using NoughtsAndCrosses.Src.Repositories.Interfaces;

namespace NoughtsAndCrosses.Src.Logic
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
            var board = _boardRepository.AddBoard(Mapper.MapBoardDtoToBoard(boardDto));
            return Mapper.MapBoardToBoardDto(board);
        }

        public bool UpdateBoard(BoardDto boardDto)
        {
            _boardRepository.UpdateBoard(Mapper.MapBoardDtoToBoard(boardDto));
            return true;
        }

        public bool DeleteBoard(int boardId)
        {
            _boardRepository.DeleteBoard(boardId);
            return true;
        }
    }
}

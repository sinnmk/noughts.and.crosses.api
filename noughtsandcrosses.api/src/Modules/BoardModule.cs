﻿using Microsoft.AspNetCore.Cors;
using Nancy;
using Nancy.IO;
using NoughtsAndCrosses.Src.Logic.Dtos;
using NoughtsAndCrosses.Src.Logic.Interfaces;

namespace NoughtsAndCrosses.Src.Modules
{
    [EnableCors]
    public class BoardModule: NancyModule
    {
        public BoardModule(IBoardLogic boardLogic): base("board")
        {
            Before += ctx => CheckAccess();
            Get("/", parameters => boardLogic.GetBoards());
            Post("/", parameters => boardLogic.CreateBoard(RequestBodyDecoder.Decode<BoardDto>(Request.Body as RequestStream)));
            Put("/", parameters => boardLogic.UpdateBoard(RequestBodyDecoder.Decode<BoardDto>(Request.Body as RequestStream)));
            Delete("/{BoardId:int}", parameters => boardLogic.DeleteBoard(parameters.BoardId));
        }

        private Response CheckAccess()
        {
            return null;
        }
    }
}

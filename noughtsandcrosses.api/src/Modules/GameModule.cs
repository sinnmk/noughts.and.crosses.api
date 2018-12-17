﻿using Nancy;
using Nancy.IO;
using NoughtsAndCrosses.Src;
using NoughtsAndCrosses.Src.Logic.Dtos;
using NoughtsAndCrosses.Src.Logic.Interfaces;

namespace noughtsandcrosses.api.Modules
{
    public class GameModule: NancyModule
    {
        public GameModule(IGameLogic gameLogic): base("game")
        {
            Before += ctx => CheckAccess();
            Get("/", parameters => gameLogic.GetGames());
            Post("/", parameters => gameLogic.CreateGame(RequestBodyDecoder.Decode<GameDto>(Request.Body as RequestStream)) );
            Put("/", parameters => gameLogic.UpdateGame(RequestBodyDecoder.Decode<GameDto>(Request.Body as RequestStream)));
            Delete("/{GameId:int}", parameters => gameLogic.DeleteGame(parameters.GameId));
        }

        private Response CheckAccess()
        {
            return null;
        }
    }
}

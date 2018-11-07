﻿using Nancy;
using Nancy.IO;
using NoughtsAndCrosses.Server.Src.Logic.Dtos;
using NoughtsAndCrosses.Server.Src.Logic.Interfaces;

namespace NoughtsAndCrosses.Server.Src.Modules
{
    public class PlayerModule : NancyModule
    {
        public PlayerModule(IPlayerLogic playerLogic) : base("player")
        {
            Before += ctx => CheckAccess();

            Get("/", parameters => playerLogic.GetPlayers());
            Post("/", parameters => playerLogic.CreatePlayer(RequestBodyDecoder.DecodeFromSnakeCase<PlayerDto>(Request.Body as RequestStream)));
            Put("/", parameters=> playerLogic.UpdatePlayer(RequestBodyDecoder.Decode<PlayerDto>(Request.Body as RequestStream)));
            Delete("/{PlayerId:int}", parameters => playerLogic.DeletePlayer(parameters.PlayerId));
        }

        private Response CheckAccess()
        {
            return null;
        }
    }
}
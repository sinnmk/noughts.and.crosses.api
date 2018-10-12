using Dash.Microservice.Core.Core;
using noughtsandcrosses.api.Dtos;
using noughtsandcrosses.api.Logic.Interfaces;
using Nancy;
using Nancy.IO;

namespace noughtsandcrosses.api.src.Modules
{
    public class PlayerModule : NancyModule
    {

        public PlayerModule(IPlayerLogic playerLogic) : base("player")
        {
            Before += ctx => CheckAccess();

            Get("/", parameters => playerLogic.GetPlayers());
            Post("/create", parameters => playerLogic.CreatePlayer(RequestBodyDecoder.DecodeFromSnakeCase<PlayerDto>(Request.Body as RequestStream)));
        }

        private Response CheckAccess()
        {
            return null;
        }
    }
}

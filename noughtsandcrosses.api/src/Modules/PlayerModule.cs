using noughtsandcrosses.api.Dtos;
using noughtsandcrosses.api.Logic.Interfaces;
using Nancy;
using Nancy.IO;

namespace noughtsandcrosses.api.Modules
{
    public class PlayerModule : NancyModule
    {

        public PlayerModule(IPlayerLogic playerLogic) : base("player")
        {
            Before += ctx => CheckAccess();

            Get("/", parameters => playerLogic.GetPlayers());
            Post("/", parameters => playerLogic.CreatePlayer(RequestBodyDecoder.DecodeFromSnakeCase<PlayerDto>(Request.Body as RequestStream)));
            Put("/", parameters=> playerLogic.UpdatePlayer(RequestBodyDecoder.Decode<PlayerDto>(Request.Body as RequestStream)));
        }

        private Response CheckAccess()
        {
            return null;
        }
    }
}

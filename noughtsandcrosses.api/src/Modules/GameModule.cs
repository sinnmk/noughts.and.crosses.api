using Dash.Microservice.Core.Core;
using noughtsandcrosses.api.Dtos;
using noughtsandcrosses.api.Logic.Interfaces;
using Nancy;
using Nancy.IO;

namespace noughtsandcrosses.api.Modules
{
    public class GameModule: NancyModule
    {
        public GameModule(IGameLogic gameLogic): base("game")
        {
            Before += ctx => CheckAccess();
            Get("/", parameters => gameLogic.GetGames());
            Post("/create", parameters => gameLogic.CreateGame(RequestBodyDecoder.DecodeFromSnakeCase<GameDto>(Request.Body as RequestStream)) );
            Put("/edit", parameters => gameLogic.UpdateGame(RequestBodyDecoder.DecodeFromSnakeCase<GameDto>(Request.Body as RequestStream)));
            Delete("/delete", parameters => gameLogic.DeleteGame(RequestBodyDecoder.DecodeFromSnakeCase<GameDto>(Request.Body as RequestStream)));
        }

        private Response CheckAccess()
        {
            return null;
        }
    }
}

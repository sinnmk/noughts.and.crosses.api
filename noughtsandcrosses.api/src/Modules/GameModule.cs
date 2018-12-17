using noughtsandcrosses.api.Logic.Dtos;
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

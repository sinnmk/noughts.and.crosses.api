using Nancy;
using Nancy.IO;
using NoughtsAndCrosses.Server.Src.Logic.Dtos;
using NoughtsAndCrosses.Server.Src.Logic.Interfaces;

namespace NoughtsAndCrosses.Server.Src.Modules
{
    public class GameModule: NancyModule
    {
        public GameModule(IGameLogic gameLogic): base("game")
        {
            Before += ctx => CheckAccess();
            Get("/", parameters => gameLogic.GetGames());
            Post("/", parameters => gameLogic.CreateGame(RequestBodyDecoder.DecodeFromSnakeCase<GameDto>(Request.Body as RequestStream)) );
            Put("/", parameters => gameLogic.UpdateGame(RequestBodyDecoder.Decode<GameDto>(Request.Body as RequestStream)));
            Delete("/{GameId:int}", parameters => gameLogic.DeleteGame(parameters.GameId));
        }

        private Response CheckAccess()
        {
            return null;
        }
    }
}

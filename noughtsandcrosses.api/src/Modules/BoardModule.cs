using Dash.Microservice.Core.Core;
using noughtsandcrosses.api.Dtos;
using noughtsandcrosses.api.Logic.Interfaces;
using Nancy;
using Nancy.IO;

namespace noughtsandcrosses.api.Modules
{
    public class BoardModule: NancyModule
    {
        public BoardModule(IBoardLogic boardLogic): base("board")
        {
            Before += ctx => CheckAccess();
            Get("/", parameters => boardLogic.GetBoards());
            Post("/create", parameters => boardLogic.CreateBoard(RequestBodyDecoder.DecodeFromSnakeCase<BoardDto>(Request.Body as RequestStream)));
            Put("/edit", parameters => boardLogic.UpdateBoard(RequestBodyDecoder.DecodeFromSnakeCase<BoardDto>(Request.Body as RequestStream)));
            Delete("/delete", parameters => boardLogic.DeleteBoard(RequestBodyDecoder.DecodeFromSnakeCase<BoardDto>(Request.Body as RequestStream)));
        }

        private Response CheckAccess()
        {
            return null;
        }
    }
}

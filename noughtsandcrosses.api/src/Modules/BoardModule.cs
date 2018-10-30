using noughtsandcrosses.api.Logic.Dtos;
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
            Post("/", parameters => boardLogic.CreateBoard(RequestBodyDecoder.DecodeFromSnakeCase<BoardDto>(Request.Body as RequestStream)));
            Put("/", parameters => boardLogic.UpdateBoard(RequestBodyDecoder.Decode<BoardDto>(Request.Body as RequestStream)));
            Delete("/{BoardId:int}", parameters => boardLogic.DeleteBoard(parameters.BoardId));
        }

        private Response CheckAccess()
        {
            return null;
        }
    }
}

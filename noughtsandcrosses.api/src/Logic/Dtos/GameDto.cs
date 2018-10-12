using System;
namespace noughtsandcrosses.api.Dtos
{
    public class GameDto
    {
        public int GameId { get; set; }
        public bool IsGameOver { get; set; }
        public bool IsGameWon { get; set; }
    }
}

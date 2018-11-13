namespace NoughtsAndCrosses.Src.Logic.Dtos
{
    public class GameDto
    {
        public int GameId { get; set; }
        public int TurnChoice { get; set; }
        public int GameLevel { get; set; }
        public int BoardDimension { get; set; }
        public bool IsGameOver { get; set; }
        public bool IsGameWon { get; set; }
    }
}

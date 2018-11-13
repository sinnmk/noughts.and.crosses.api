namespace NoughtsAndCrosses.Src.Logic.Dtos
{
    public class BoardDto
    {
        public int BoardId { get; set; }
        public int BoardDimension { get; set; }
        public bool IsTerminal { get; set; }
        public string BoardState { get; set; }
    }
}
